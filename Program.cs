using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo2pk
{
    internal class Library_Managment_System
    {
        string UserType, Username, Password;
        public void Login()
        {
            Console.WriteLine("Login");
        }
        public void Register()
        {
            Console.WriteLine("Register");
        }
        public void Logout()
        {
            Console.WriteLine("Logout");
        }
    }
    internal class User
    {
        public string name;
        public int id;
        public Library_Managment_System lms;
        public void Verify()
        {
            Console.WriteLine("Verify");
        }
        public void CheckAccount()
        {
            Console.WriteLine("CheckAccount");
        }
        public void get_book_info()
        {
            Console.WriteLine("get book info");
        }
    }
    internal class Book
    {
        string Title, Author, ISBN, Publication;
        public Library_Managment_System lms;
        public User user;
        public void Show_duedt()
        {
            Console.WriteLine("Show duedt");
        }
        public void Reservation_status()
        {
            Console.WriteLine("Reservation status");
        }
        public void Feedback()
        {
            Console.WriteLine("Feedback");
        }
        public void Book_request()
        {
            Console.WriteLine("Book request");
        }
        public void Renw_info()
        {
            Console.WriteLine("Renw_info");
        }
    }
    internal class Librarian
    {
        public string Name, Password, SearchString;
        public int ID;
        public Library_Managment_System lms;
        List<Book> listOfRentedBooks;
        public void Verify_librarian()
        {
            Console.WriteLine("Verify Librarian");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }
        public void RentBook()
        {
            Library_database db = new Library_database();
            Book ksiazka = new Book();
            db.Search();
            listOfRentedBooks.Add(ksiazka);
            Console.WriteLine("Rent Book");
        }
    }
    internal class Account
    {
        string no_borrowed_books, no_reserved_books, no_returned_books, no_lost_books, fine_amount;
        public User user;
        public void calculate_fine()
        {
            Console.WriteLine("Calculate Fine");
        }
    }
    internal class Library_database
    {
        public List<string> ListOfBooks = new List<string>();
        Librarian lib;
        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Delete()
        {
            Console.WriteLine("Delete");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }
        public void getLibrarian()
        {
            Console.WriteLine("Librarian: xxx");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Show_duedt();
            book1.Feedback();

            Librarian libek = new Librarian();
            libek.Name = "Bartosz";
            libek.ID = 123;
            libek.Verify_librarian();
            List<Book> lista = new List<Book>();
            lista.Add(book1);
            libek.RentBook();
        }
    }
}
