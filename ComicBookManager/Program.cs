using System;

namespace ComicBookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("****Comic Book Manager****");
            Console.WriteLine("**************************");

            while(true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add a Comic");
                Console.WriteLine("2. Delete a Comic");
                Console.WriteLine("3. List Comics by Book Title");
                Console.WriteLine("4. List Comics by Publisher");
                Console.WriteLine("5. List Comic Details");
                Console.WriteLine("6. List All Comics");
                Console.Write("Please select an option: ");
                var option = Console.ReadLine();

                switch(option)
                {
                    case "0":
                        break;

                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                }
            }

            /*var MyComic = new ComicBook("DC", "Superman", 300, DateTime.Parse("1976-03-11"), 0.30m);
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
            */
        }
    }
}
