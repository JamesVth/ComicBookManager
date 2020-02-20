using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComicBookManager
{
    static class Librarian
    {
        private static List<ComicBook> collection = new List<ComicBook>();
        private static List<Contributor> contributors = new List<Contributor>();
        private static List<Character> characters = new List<Character>();

        /// <summary>
        /// Add a comic book
        /// </summary>
        /// <param name="publisher">The publisher of the comic</param>
        /// <param name="bookTitle">The title of the comic</param>
        /// <param name="issueNumber">The issue number</param>
        /// <param name="publishedDate">The date the comic was published</param>
        /// <param name="coverPrice">The cover price of the comic</param>
        /// <returns>A comic book class</returns>
        static void AddComic(string publisher, string bookTitle, int issueNumber, DateTime publishedDate, Decimal coverPrice)
        {
            var newcomic = new ComicBook(publisher, bookTitle, issueNumber, publishedDate, coverPrice);
            collection.Add(newcomic);
        }

        static void AddCharacterToComic(ComicBook comic, string charactername, TypeOfCharacter charactertype)
        {
            var character = characters.FirstOrDefault(c => c.CharacterName == charactername);
            if(character == null)
            {
                var newcharacter = new Character(charactername, charactertype);
                characters.Add(newcharacter);
                comic.AddCharacter(newcharacter);
            }
            else
            {
                comic.AddCharacter(character);
            }

        }
        static void AddContributorToComic(ComicBook comic, string contributorname, TypeOfContributor contributortype)
        {
            var contributor = contributors.FirstOrDefault(c => c.ContributorName == contributorname);
            if (contributor == null)
            {
                var newcontributor = new Contributor(contributorname, contributortype);
                contributors.Add(newcontributor);
                comic.AddConstributor(newcontributor);
            }
            else
            {
                comic.AddConstributor(contributor);
            }

        }

        static IEnumerable<ComicBook> ListComicsByBookTitle(string bookTitle)
        {
            return collection.Where(a => a.BookTitle == bookTitle);
        }

        static IEnumerable<ComicBook> ListComicsByPublisher(string publisher)
        {
            return collection.Where(a => a.Publisher == publisher);
        }

        static IEnumerable<ComicBook> ListComicsByCharacter(string charactername)
        {
            var character = characters.First(c => c.CharacterName == charactername);
            return collection.Where(cb => cb.Characters.Contains(character));
        }

        static IEnumerable<ComicBook> ListComicsByContributor(string contributorname)
        {
            var contributor = contributors.First(c => c.ContributorName == contributorname);
            return collection.Where(cb => cb.Contributors.Contains(contributor));
        }
    }
}
