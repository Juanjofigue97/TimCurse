using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonModelLibrary;

namespace RazorPageTimSolution.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }

    }
}
