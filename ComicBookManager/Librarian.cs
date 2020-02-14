using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComicBookManager
{
    static class Librarian
    {
        private static List<ComicBook> collection = new List<ComicBook>();

        /// <summary>
        /// Add a comic book
        /// </summary>
        /// <param name="publisher">The publisher of the comic</param>
        /// <param name="bookTitle">The title of the comic</param>
        /// <param name="issueNumber">The issue number</param>
        /// <param name="publishedDate">The date the comic was published</param>
        /// <param name="coverPrice">The cover price of the comic</param>
        /// <returns>A comic book class</returns>
        static ComicBook AddComic(string publisher, string bookTitle, int issueNumber, DateTime publishedDate, Decimal coverPrice)
        {
            var newcomic = new ComicBook(publisher, bookTitle, issueNumber, publishedDate, coverPrice);
            collection.Add(newcomic);
            return newcomic;
        }

        static IEnumerable<ComicBook> ListComicsByBookTitle(string bookTitle)
        {
            return collection.Where(a => a.BookTitle == bookTitle);
        }

        static IEnumerable<ComicBook> ListComicsByPublisher(string publisher)
        {
            return collection.Where(a => a.Publisher == publisher);
        }
    }
}
