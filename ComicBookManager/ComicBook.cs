using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookManager
{
    class ComicBook
    {
        #region Properties
        public string BookTitle { get; set; }
        public int IssueNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal CoverPrice { get; set; }
        public string CoverArtist { get; set; }
        public string StoryTitle { get; set; }
        public string Note { get; set; }
        public List<string> Writers { get; set; }
        public List<string> Pencillers { get; set; }
        public List<string> Inkers { get; set; }
        public List<string> Colorists { get; set; }
        public List<string> Characters { get; set; }
        #endregion
    }
}
