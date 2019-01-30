using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();

            while (true)
            {
                Console.WriteLine("List of Commands\n" +
                    "add: add a book to the list\n" +
                    "remove: remove a book from the list\n" +
                    "list: prints all books in the list");
                Console.WriteLine("Input Command");
                string command = Console.ReadLine();
                if (command == "add")
                {
                    // add to list
                    Console.WriteLine("Input book title");
                    string bookTitle = Console.ReadLine();
                    books.Add(bookTitle);
                    Console.WriteLine($"{bookTitle} has been added.");
                }
                else if (command == "list")
                {
                    // print list of books
                    foreach (string book in books)
                    {
                        Console.WriteLine(book);
                    }
                }
                else if (command == "remove")
                {
                    //remove a book from the list
                    Console.WriteLine("What book do you want to remove?");
                    string bookRemove = Console.ReadLine();
                    if (books.IndexOf(bookRemove) == -1)
                    {
                        Console.WriteLine($"{bookRemove} is not in the list.");
                    }
                    else
                    {
                        books.Remove(bookRemove);
                        Console.WriteLine($"{bookRemove} has been removed.");
                    }
                }
                else if (command == "q")
                {
                    break;
                }
            }
        }
    }
}
