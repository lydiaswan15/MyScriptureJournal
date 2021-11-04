using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public List<Scripture> Scriptures { get; set; }
    }
}