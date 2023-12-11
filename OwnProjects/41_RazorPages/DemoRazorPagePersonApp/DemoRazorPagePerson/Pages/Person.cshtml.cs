using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPagePerson.Pages
{
    public class PersonModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public int Age { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            return Page();
        }
    }
}
