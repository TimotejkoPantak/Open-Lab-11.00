using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        /// <summary>
        /// Create category list for books
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
            if (releaseDate < 1450 || releaseDate > 2020)
            {
                ReleaseDate = -1;
            }
            else
            {
                ReleaseDate = releaseDate;
            }

            if (pages < 0)
            {
                Pages = 1;
            }
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { private get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }



        public void Statement()
        {
            Console.Write($"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}\n\n");
        }
    }
}
