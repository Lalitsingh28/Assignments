using LibraryManagementSystem.DBContext;
using LibraryManagementSystem.Model;
using System;
using System.Net;

class Program
{
  

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update a Book");
            Console.WriteLine("4. Delete a Book");
            Console.WriteLine("5. Add a Patron");
            Console.WriteLine("6. View Patrons");
            Console.WriteLine("7. Update a Patron");
            Console.WriteLine("8. Delete a Patron");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBooks();
                    Console.WriteLine("Book Added");
                    break;

                case "2":
                    Console.WriteLine("Enter ID of the Book to read");
                    int id =  int.Parse(Console.ReadLine());
                    ReadBook(id);
                    break;

                case "3":
                    // Implement logic to update a book
                    Console.WriteLine("Enter ID of Book To Update");
                    int bookid = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Title to Update");
                    string title = Console.ReadLine();
                    UpdateBook(bookid,title);
                    Console.WriteLine("Title Updated");
                    break;
                case "4":
                    // Implement logic to delete a book
                    Console.WriteLine("Enter ID to Delete Book");
                    int bookId = int.Parse(Console.ReadLine());
                    DeleteBook(bookId);
                    Console.WriteLine("Book Deleted");
                    break;
                case "5":
                    // Implement logic to add a patron
                    break;
                case "6":
                    // Implement logic to view patrons
                    break;
                case "7":
                    // Implement logic to update a patron
                    break;
                case "8":
                    // Implement logic to delete a patron
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }


    }


    public static void AddBooks()
    {
        using (var context = new LibraryContext())
        {
            var newBook = new Book { Title = "Sample Book", Author = "Author Name", PublicationDate = DateTime.Now };
            context.Books.Add(newBook);
            context.SaveChanges();
        }

    }

    public static void ReadBook(int id)
    {
        using (var context = new LibraryContext())
        {
            var allBooks = context.Books.ToList();
            var specificBook = context.Books.Find(id);
            Console.WriteLine("Book ID : " + specificBook.Id);
            Console.WriteLine("Book Title : " + specificBook.Title);
            Console.WriteLine("Book Author : " + specificBook.Author);
        }

    }

    public static void UpdateBook(int bookId, string title)
    {
        using (var context = new LibraryContext())
        {
            var bookToUpdate = context.Books.Find(bookId);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = "Updated Title";
                context.Books.Update(bookToUpdate);
                context.SaveChanges();
            }
        }

    }

    public static void DeleteBook(int id)
    {
        using (var context = new LibraryContext())
        {
            var bookToDelete = context.Books.Find(id);
            if (bookToDelete != null)
            {
                context.Books.Remove(bookToDelete);
                context.SaveChanges();
            }
        }

    }


}
