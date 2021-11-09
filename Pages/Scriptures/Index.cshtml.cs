using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MySciptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }



        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Chapters { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureChapter { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from s in _context.Scripture
                                            orderby s.Book.BookName
                                            select s.Book.BookName;

            var scriptures = from s in _context.Scripture
                             select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureChapter))
            {
                scriptures = scriptures.Where(x => x.Book.BookName == ScriptureChapter);
            }
            Chapters = new SelectList(await genreQuery.Distinct().ToListAsync());
            Scripture = await scriptures.ToListAsync();
        }

    }
}
