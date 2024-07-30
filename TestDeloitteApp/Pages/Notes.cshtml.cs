using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TestDeloitteApp.Data;
using TestDeloitteApp.Models;

namespace TestDeloitteApp.Pages
{
    public class NotesModel : PageModel
    {
        [BindProperty]
        public CaseDiaryNote CaseDiaryNote { get; set; }
        public CaseDiary CaseDiary { get; set; }

        private readonly TestDeloitteAppContext _context;
        public NotesModel(TestDeloitteAppContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CaseDiaryNote = _context.CaseDiaryNotes.Where(x => x.CaseDiaryId == id).FirstOrDefault();
            CaseDiary = _context.CaseDiaries.Where(x => x.Id == id).FirstOrDefault();
            if (CaseDiaryNote == null)
            {
                CaseDiaryNote = new CaseDiaryNote()
                {
                    Id = _context.CaseDiaryNotes.Count() + 1,
                    CaseDiaryId = (int)id,
                };
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (_context.CaseDiaryNotes.Any(e => e.Id == CaseDiaryNote.Id))
            {
                 _context.CaseDiaryNotes.Update(CaseDiaryNote);
                await _context.SaveChangesAsync();
            }
            else
            {
                await _context.CaseDiaryNotes.AddAsync(CaseDiaryNote);
                await _context.SaveChangesAsync();
            }
            CaseDiary = _context.CaseDiaries.Where(x => x.Id == CaseDiaryNote.CaseDiaryId).FirstOrDefault();

            return Page();
        }
    }
}
