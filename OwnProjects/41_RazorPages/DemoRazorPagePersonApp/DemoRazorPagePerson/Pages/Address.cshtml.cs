using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPagePerson.Pages
{
    public class AddressModel : PageModel
    {
        [BindProperty]
        public string Country { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string Neighborhood { get; set; }
        [BindProperty]
        public string Street { get; set; }
        [BindProperty]
        public string PostalCode { get; set; }

        public void OnGet()
        {
            ViewData["isValid"] = false;
        }

        public IActionResult OnPost()
        {
            ViewData["isValid"] = true;
            return Page();
        }
    }
}
