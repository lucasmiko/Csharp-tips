// Classes e Métodos
namespace ExampleNamespace
{
    public class ExampleClass
    {
        public void ExampleMethod()
        {
            Console.WriteLine("Este é um método de exemplo.");
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("Adicionando dois números.");
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass example = new ExampleClass();
            example.ExampleMethod();
            int result = example.Add(5, 3);
            Console.WriteLine("Resultado: " + result);
        }
    }
}

// Estruturas de Controle de Fluxo
// If-Else
namespace ControlFlowExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (number < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}

// Loops
// While Loop
namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("Valor de i: " + i);
                i++;
            }
        }
    }
}

// For Loop
namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }
        }
    }
}

// Injeção de Dependência
namespace DependencyInjectionExample
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Serviço está sendo executado.");
        }
    }

    public class Client
    {
        private readonly IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public void Start()
        {
            Console.WriteLine("Cliente está iniciando o serviço.");
            _service.Serve();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IService service = new Service();
            Client client = new Client(service);
            client.Start();
        }
    }
}

// Exceções
namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Bloco finally executado.");
            }
        }
    }
}

// Linq
namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Números pares:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

// Hack
namespace LibrarySystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }

    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book}");
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = books.Find(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book removed: {bookToRemove}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ListBooks()
        {
            Console.WriteLine("Listing all books:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchByTitle(string title)
        {
            Console.WriteLine($"Searching for books with title: {title}");
            var foundBooks = books.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            if (foundBooks.Count > 0)
            {
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books found with that title.");
            }
        }

        public void SearchByAuthor(string author)
        {
            Console.WriteLine($"Searching for books by author: {author}");
            var foundBooks = books.FindAll(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
            if (foundBooks.Count > 0)
            {
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books found by that author.");
            }
        }

        public void UpdateBook(string isbn, string newTitle, string newAuthor)
        {
            Book bookToUpdate = books.Find(b => b.ISBN == isbn);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = newTitle;
                bookToUpdate.Author = newAuthor;
                Console.WriteLine($"Book updated: {bookToUpdate}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void CountBooks()
        {
            Console.WriteLine($"Total number of books: {books.Count}");
        }

        public void ClearLibrary()
        {
            books.Clear();
            Console.WriteLine("Library cleared.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234567890"));
            library.AddBook(new Book("1984", "George Orwell", "1234567891"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "1234567892"));

            // Listing books
            library.ListBooks();

            // Searching books
            library.SearchByTitle("1984");
            library.SearchByAuthor("Harper Lee");

            // Updating a book
            library.UpdateBook("1234567890", "The Great Gatsby", "Francis Scott Fitzgerald");

            // Removing a book
            library.RemoveBook("1234567891");

            // Counting books
            library.CountBooks();

            // Clearing the library
            library.ClearLibrary();

            // Listing books after clearing
            library.ListBooks();
        }
    }
}
