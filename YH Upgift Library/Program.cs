
using System;
using Library_Live;
using Library_Live.Library_Live;

class Program
{

    static void Main()
    {
        // here is were all the books are going to be
        Library library = new Library();

        // And here are the added bookes. the one we have 
        Book book1 = new Book("Dark Desiple", "Unknown", 2015, 540);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 300);
        Book book3 = new Book("Harry Potter", "J.K. Rowling", 2007, 400);
        Book book4 = new Book("Fire and Blood", "George R.R. Martin", 2018, 780);
        Book book5 = new Book("Adam in Jungle", "Robert G.M", 2002, 54);

        // this place is were all the books are added to the "library" class.
        library.Addabook(book1);
        library.Addabook(book2);
        library.Addabook(book3);
        library.Addabook(book4);
        library.Addabook(book5);

        // here we have commands for sorting books and listing them in alphabetick order.
        library.SortBooks();
        library.ListBooks();

        // here i we can search for books and a reminder that you cant search with an empty soth T_T.
        Console.WriteLine("\nSearch (title/author): ");
        string search = Console.ReadLine();
        
            if (search != "")
            {
                library.Searchforbook(search);
            }
            else
            {
                Console.WriteLine("Search sloth cannot be empty.");
            }
        
    }
}


