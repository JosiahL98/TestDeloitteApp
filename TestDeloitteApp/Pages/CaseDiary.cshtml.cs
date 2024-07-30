using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.Json;
using System.Xml.Linq;
using TestDeloitteApp.Data;
using TestDeloitteApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestDeloitteApp.Pages
{
    public class CaseDiaryModel : PageModel
    {
        [BindProperty]
        public CaseDiarySearch caseDiarySearch {  get; set; }
        //[BindProperty, Required, Display(Name = "Case Id")]
        //public string CaseId { get; set; }
        //[BindProperty, Display(Name = "Function Type")]
        //public string? FunctionType { get; set; }
        //[BindProperty, Display(Name = "Sub Function Type")]
        //public string? SubFunctionType { get; set; }
        //[BindProperty, Required]
        //public string Open { get; set; }
        //[BindProperty, Required, Display(Name = "Primary Activity Type")]
        //public string Prim { get; set; }
        //[BindProperty, Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        //public DateTime StartDate { get; set; }

        public List<SelectListItem> FunctionTypes = new List<SelectListItem>()
        {
            new SelectListItem { Value = null, Text = null },
            new SelectListItem { Value = "aaaaa", Text = "aaaaa" },
            new SelectListItem { Value = "bbbb", Text = "bbbb" },
            new SelectListItem { Value = "ccccc", Text = "ccccc" },
            new SelectListItem { Value = "dddd", Text = "dddd" }
        };
        public List<SelectListItem> SubFunctionTypes = new List<SelectListItem>()
        {
            new SelectListItem { Value = null, Text = null },
            new SelectListItem { Value = "aaaaa", Text = "aaaaa" },
            new SelectListItem { Value = "bbbb", Text = "bbbb" },
            new SelectListItem { Value = "ccccc", Text = "ccccc" },
            new SelectListItem { Value = "dddd", Text = "dddd" }
        };
      
        public List<SelectListItem> YesNoTypes = new List<SelectListItem>()
        {
            new SelectListItem { Value = "Yes", Text = "Yes" },
            new SelectListItem { Value = "No", Text = "No" }
        };
          
        public List<CaseDiary> CaseDiariesList { get; set; }

        private readonly TestDeloitteAppContext _context;
        public CaseDiaryModel(TestDeloitteAppContext context) {
            _context = context;
        }
            

        public async Task OnGetAsync()
        {
            caseDiarySearch = new CaseDiarySearch();

            caseDiarySearch.StartDate = new DateTime(DateTime.Now.Ticks, DateTimeKind.Unspecified);


            CaseDiariesList = await _context.CaseDiaries.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            
            

            YesNoTypes = new List<SelectListItem>();
            YesNoTypes.Add(new SelectListItem { Value = "Yes", Text = "Yes" });
            YesNoTypes.Add(new SelectListItem { Value = "No", Text = "No" });
            CaseDiariesList = await _context.CaseDiaries.ToListAsync();
            if (ModelState.IsValid)
            {
                CaseDiariesList = CaseDiariesList.Where(x => x.CaseId == caseDiarySearch.CaseId).ToList();
                CaseDiariesList = CaseDiariesList.Where(x => x.Open == caseDiarySearch.Open).ToList();
                CaseDiariesList = CaseDiariesList.Where(x => x.Prim == caseDiarySearch.Prim).ToList();
                CaseDiariesList = CaseDiariesList.Where(x => x.StartDate >= caseDiarySearch.StartDate).ToList();
                if (caseDiarySearch.FunctionType != null)
                {
                    CaseDiariesList = CaseDiariesList.Where(x => x.Function == caseDiarySearch.FunctionType).ToList();
                }
                if (caseDiarySearch.SubFunctionType != null)
                {
                    CaseDiariesList = CaseDiariesList.Where(x => x.SubFunction == caseDiarySearch.SubFunctionType).ToList();
                }

            }
            

            return Page();
        }
        public async Task<IActionResult> OnPostClearAsync()
        {


            YesNoTypes = new List<SelectListItem>();
            YesNoTypes.Add(new SelectListItem { Value = "Yes", Text = "Yes" });
            YesNoTypes.Add(new SelectListItem { Value = "No", Text = "No" });
            CaseDiariesList = await _context.CaseDiaries.ToListAsync();
            caseDiarySearch = new CaseDiarySearch();
            caseDiarySearch.CaseId = null;
            caseDiarySearch.StartDate = new DateTime(DateTime.Now.Ticks, DateTimeKind.Unspecified);

            return RedirectToPage();

            //return Page();
        }
    }
}
