using System;
using System.Diagnostics;

namespace Notizen.Models
{
    public class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }

    }
}