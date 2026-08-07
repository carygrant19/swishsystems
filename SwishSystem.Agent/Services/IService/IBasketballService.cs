using DTO = SwishSystem.Agent.DTOs.Basketball;

namespace SwishSystem.Agent.Services.IService
{
    public interface IBasketballService
    {
        Task<DTO.Response.Report?> GenerateReport(string request);
    }
}
