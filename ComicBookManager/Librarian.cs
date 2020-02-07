using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookManager
{
    static class Librarian
    {
        static ComicBook AddComic(string publisher, string bookTitle, int issueNumber, DateTime publishedDate, Decimal coverPrice)
        {
            var newcomic = new ComicBook(publisher, bookTitle, issueNumber, publishedDate, coverPrice);
            return newcomic;
        }
    }
}
