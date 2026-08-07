using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwishSystem.Agent.Services.IService;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using DTO = SwishSystem.Agent.DTOs.Basketball;
using Model = SwishSystem.Agent.Models;

namespace SwishSystem.Agent.Services
{
    public class BasketballService(IConfiguration configuration, IWebHostEnvironment env, IMemoryCache cache, ILogger<BasketballService> logger) : IBasketballService
    {
        private readonly ILogger<BasketballService> _logger = logger;
        private readonly string _apiKey = configuration["Gemini:ApiKey"]!;
        private readonly string _endpoint = configuration["Gemini:Endpoint"]!;
        private readonly IWebHostEnvironment _env = env;
        private readonly IMemoryCache _cache = cache;

        public async Task<DTO.Response.Report> GenerateReport(string dtoRequest)
        //public async Task<DTO.Response.Report> Chat(DTO.Request.Report dtoRequest)
        {

            string promptFilePath = Path.Combine(_env.ContentRootPath, "prompts", "sportscaster", $"basketball.txt");

            string promptTemplate = await System.IO.File.ReadAllTextAsync(promptFilePath);

            string promptText = await File.ReadAllTextAsync(promptFilePath);

            //promptText = promptText.Replace("{{GAME_JSON}}", dtoRequest);

            var endpoint = $"{_endpoint}{_apiKey}";

            Model.Gemini.Request request = new()
            {
                Contents =
                [
                    new() {
                        Parts =
                        [
                            new Model.Gemini.Part { Text = promptText }
                        ]
                    }
                ]
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            StringContent? content = new(System.Text.Json.JsonSerializer.Serialize(request, options), Encoding.UTF8, "application/json");

            using HttpClient client = new();
            client.Timeout = Timeout.InfiniteTimeSpan;
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            HttpResponseMessage httpResponse = await client.PostAsync(endpoint, content);
            httpResponse.EnsureSuccessStatusCode();

            var rawResponseString = await httpResponse.Content.ReadAsStringAsync();

            var jsonDoc = JObject.Parse(rawResponseString);

            var aiText = jsonDoc["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString() ?? "";

            var cleanJson = aiText.Replace("```json", "").Replace("```", "").Trim();

            var dtoResponse = JsonConvert.DeserializeObject<DTO.Response.Report>(cleanJson);

            return dtoResponse;

        }
    }
}
