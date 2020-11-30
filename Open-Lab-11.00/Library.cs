using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        int numberOfStudents = 2;
        int numberOfBooks = 4;

        public List<string> studentsList = new List<string>() { };
        public List<Book> booksList = new List<Book>() { };

        public int NumberOfBooks { get; set; }
        public int NumberOfStudents { get; set; }

        public void ShowVariables()
        {
            Console.WriteLine($"Number of books: {numberOfBooks}\nNumber of students: {numberOfStudents}\n");
            foreach (var student in studentsList)
            {
                Console.WriteLine("Stuent " + student);
            }

            Console.WriteLine("\n");

            foreach (var book in booksList)
            {
                book.Statement();
            }
        }
    }
}
