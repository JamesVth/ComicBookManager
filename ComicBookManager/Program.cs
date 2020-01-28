using System;

namespace ComicBookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyComic = new ComicBook("DC", "Superman", 300, DateTime.Parse("1976-03-11"), 0.30m);
            MyComic.StoryTitle = "Superman 2001";
            MyComic.CoverArtist = "Bob Oksner";
            MyComic.AddWriter("Cary Bates");
            MyComic.AddWriter("Elliot S Maggin");
            MyComic.AddPenciller("CurtSwan");
            MyComic.AddInker("Bob Oksner");
            MyComic.AddCharacter("Superman");
            MyComic.AddCharacter("Jor-El");
            MyComic.AddCharacter("Lara");
            MyComic.AddCharacter("Lt. Thomas Clark");
            MyComic.AddCharacter("Gen. Kent Garrett");
            MyComic.AddCharacter("Premier Leonov");
            MyComic.AddCharacter("Pres. Weiner");
            MyComic.AddCharacter("Moka");

            Console.WriteLine($"Comic Book: Publisher:{MyComic.Publisher}, Title:{MyComic.BookTitle}, Published:{MyComic.PublishedDate:yyyy/MM/dd}, CoverPrice:{MyComic.CoverPrice}");
        }
    }
}
