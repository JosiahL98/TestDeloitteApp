using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TestDeloitteApp.Pages
{
    public class TesterModel : PageModel
    {
        [BindProperty]
        public string TestString { get; set; }
        [BindProperty, Compare(nameof(TestString))]
        public string TestString2 { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Test"] = TestString;
            return Page();
        }
    }
}
