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
        public List<Contributor> Contributors { get; private set; }
        public List<Character> Characters { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Add a writer to the comic book
        /// </summary>
        /// <param name="Writer">The writer's name</param>
        public void AddConstributor(Contributor contributor)
        {
            Contributors.Add(contributor);
        }

        /// <summary>
        /// Add a character to the comic book
        /// </summary>
        /// <param name="Character">The character's name</param>
        public void AddCharacter(Character character)
        {
            Characters.Add(character);
        }
        #endregion

        #region Contructors
        /// <summary>
        /// Constructor for the comic book class
        /// </summary>
        /// <param name="Publisher">The name of the publisher</param>
        /// <param name="BookTitle">The comic book's title</param>
        /// <param name="IssueNumber">The comic book's issue number</param>
        /// <param name="PublishedDate">The comic book's published date</param>
        /// <param name="CoverPrice">The comic book's cover price</param>
        public ComicBook(string Publisher, string BookTitle, int IssueNumber, DateTime PublishedDate, Decimal CoverPrice)
        {
            this.Publisher = Publisher;
            this.BookTitle = BookTitle;
            this.IssueNumber = IssueNumber;
            this.PublishedDate = PublishedDate;
            this.CoverPrice = CoverPrice;
        }
        #endregion
    }
}
