using System;
using System.Collections.Generic;

/*

Make a Book class that has:
- Title
- Author 
- ISBN

Make a Library class that has:
- Private List of Books (remember casing and naming convention here)
- Public Method to add a Book to the List of Books
- Public Address property
- Public Name property


:zap:
Create a few (4 or so) instances of books and 
  use the method on your Library class to add them to the list of books 
  in an instance of Library
 */


namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book endersGame = new Book() {
                Title = "Ender's Game",
                Author = "Orsen Scott",
                ISBN = "ABC123"
            };

            Book tomSawyer = new Book();
            tomSawyer.Title = "Tom Sawyer";
            tomSawyer.Author = "Mark Twain";
            tomSawyer.ISBN = "23234ASSDFSDA";

            Book lotr = new Book() {
                Title = "Lord of the Rings",
                Author = "J R R Tolkien",
                ISBN = "ABC12323423"
            };

            Book twilight = new Book() {
                Title = "Twilight",
                Author = "Stephanie Meyers",
                ISBN = "C2SDFSDF123"
            };

            Book book1 = new Book() {
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A"
            };

            Book book2 = new Book() {
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B",
                IsAvailable = false
            };
            Console.WriteLine($"book2 isavaialble = {book2.IsAvailable}");

            List<Book> books = new List<Book>(){
                book1, book2
            };
            Library library = new Library(books, "Downtown Library", "123 Some St. Nashville, TN 11111");

            library.AddToInventory(endersGame);
            library.AddToInventory(lotr);
            library.AddToInventory(tomSawyer);
            library.AddToInventory(twilight);

            if (library.IsAvailable("2B"))
            {
                Console.WriteLine("2B is available");
            } 
            else 
            {
                Console.WriteLine("2B is unavailable");
            }
/* 
            library.AddToInventory(
                new Book() {
                    Title = "foo", Author = "bar", ISBN = "123"
                });
*/
        }
    }
}



