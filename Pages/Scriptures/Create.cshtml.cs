using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Models;

namespace MySciptureJournal.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["BookId"] = new SelectList(_context.Set<Book>(), "BookId", "BookId");
            return Page();
        }

        [BindProperty]
        public Scripture Scripture { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Scripture.DateCreated = DateTime.Now;

            _context.Scripture.Add(Scripture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
