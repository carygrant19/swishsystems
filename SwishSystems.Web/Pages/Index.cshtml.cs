using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SwishSystems.Web.Models;

namespace SwishSystems.Web.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ContactFormModel ContactForm { get; set; } = new ContactFormModel();

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var name = ContactForm.Name;
            var email = ContactForm.Email;

            return RedirectToPage("Index");
        }
    }
}
