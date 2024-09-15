using System;
using System.Text;

namespace Library_Live
{
    internal class Book
    {
        // there are the properties we are going to use:
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int publicationYear, int pages)
        {
            Title = title;
            Author = author;
            Year = publicationYear;
            Pages = pages;
        }
    }
        namespace Library_Live
        {
        internal class Library
        {
            // Here is the list that all books are saved here.
            public List<Book> books = new List<Book>();



            public void Addabook(Book book)
            { 
                books.Add(book);
            
            }

            // this part was my brothers idea to make the "if" part 
            // so if there are no books avilable. a short massage would tell.
            public void ListBooks()
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("Sorry but there are no books available in the moment.");
                    return;
                }

                Console.WriteLine("\nBooks in our Library:");
                foreach (var book in books)
                {
                    PrintBook(book);
                }
            }

            // This part i didnt fully understand i got help from chatgbt
            // but its a way for searching for the wanted book, either by title or the writer
            public void Searchforbook(string search)
            {
                var foundBooks = books.Where(b => b.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                b.Author.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

                if (foundBooks.Count == 0)
                {
                    Console.WriteLine($"No books found for '{search}'.");
                }
                else
                {
                    Console.WriteLine($"\n results for '{search}':");
                    foreach (var book in foundBooks)
                    {
                        PrintBook(book);
                    }
                }
            }

            // Here is were we can sort all book by alphabet.
            // also chatgbt understand how it works just not really well.
            public void SortBooks()
            {
                books = books.OrderBy(b => b.Title).ToList();
                Console.WriteLine("\nBooks sorted by title.");
            }

            // and in the end this is how i want it to be shown on the screan. all the info in one sentence
            public void PrintBook(Book book)
            {
                Console.WriteLine($"{book.Title} by {book.Author}, Published in ({book.Year}) Pages: {book.Pages}");
            }
        }
    }
}

