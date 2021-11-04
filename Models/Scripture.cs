using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureId { get; set; }
        public int BookId { get; set; }

        public string Verses { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public Book Book { get; set; }

    }
}