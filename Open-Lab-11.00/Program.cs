using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();
            schoolLibrary.studentsList.Add("John");
            schoolLibrary.booksList.Add(new Book ("Geografia", 382, Book.categoryList[2], "Alena Dubcová",2019));
            schoolLibrary.booksList.Add(new Book("Maturita - Dejepis",422, Book.categoryList[2], "Jana Hečková", 2016));

            schoolLibrary.studentsList.Add("Paul");
            schoolLibrary.booksList.Add(new Book("Angličtina",160,Book.categoryList[2],"Magdalena Filak", 2020));
            schoolLibrary.booksList.Add(new Book("Nemčina",400,Book.categoryList[2], "Lilli Marlen Brill", 2013));

            schoolLibrary.ShowVariables();
        }
    }
}
