using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookManager
{
    enum BasicGrade { Near_Mint, Verry_Fine, Fine, Very_Good, Good, Fair, Poor }
    class ComicBook
    {
        #region Properties
        public string Publisher { get; set; }
        public string BookTitle { get; set; }
        public int IssueNumber { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal CoverPrice { get; set; }
        public string CoverArtist { get; set; }
        public string StoryTitle { get; set; }
        public string Note { get; set; }
        public List<string> Writers { get; private set; }
        public List<string> Pencillers { get; private set; }
        public List<string> Inkers { get; private set; }
        public List<string> Colorists { get; private set; }
        public List<string> Characters { get; private set; }
        #endregion

        #region Methods
        public void AddWriter(string Writer)
        {
            Writers.Add(Writer);
        }

        public void AddPenciller(string Penciller)
        { 
            Pencillers.Add(Penciller);
        }

        public void AddInker(string Inker)
        {
            Inkers.Add(Inker);
        }

        public void AddColorist(string Colorist)
        {
            Colorists.Add(Colorist);
        }

        public void AddCharacter(string Character)
        {
            Characters.Add(Character);
        }
        #endregion

        #region Contructors
        public ComicBook(string Publisher, string BookTitle, int IssueNumber, DateTime PublishedDate, Decimal CoverPrice)
        {
            var Writers = new List<string>();
            var Pencillers = new List<string>();
            var Inkers = new List<string>();
            var Colorists = new List<string>();
            var Characters = new List<string>();

            this.Publisher = Publisher;
            this.BookTitle = BookTitle;
            this.IssueNumber = IssueNumber;
            this.PublishedDate = PublishedDate;
            this.CoverPrice = CoverPrice;
        }
        #endregion
    }
}
