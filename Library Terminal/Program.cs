using Library_Terminal;
using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using static System.Reflection.Metadata.BlobBuilder;

int userSelection = 0;
DateTime today = DateTime.Today;
DateTime twoWeeksFromToday = today.AddDays(14);
string displayDate = twoWeeksFromToday.ToString("yyyy-MM-dd");
string author = "default";
string keyword = "default";
string title = "default";

List<Book> bookList = new List<Book>()
{
    new Book("To Kill a Mockingbird", "Harper Lee", "checked out"),
    new Book("1984", "George Orwell", "on shelf"),
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "on shelf"),
    new Book("Pride and Prejudice", "Jane Austen", "on shelf"),
    new Book("The Catcher in the Rye", "J.D. Salinger", "on shelf"),
    new Book("The Hobbit", "J.R.R. Tolkien", "on shelf"),
    new Book("The Lord of the Rings", "J.R.R. Tolkien", "on shelf"),
    new Book("Moby-Dick", "Herman Melville", "on shelf"),
    new Book("The Adventures of Huckleberry Finn", "Mark Twain", "on shelf"),
    new Book("The Grapes of Wrath", "John Steinbeck", "on shelf"),
    new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "checked out"),
    new Book("Frankenstein", "Mary Shelley", "checked out"),
};


Console.WriteLine("Welcome to our Library! We have an extensive catalog of books for rent.");

while (true)
{
    Console.WriteLine("Please select an option from our Library Catalog Menu:");
    Console.WriteLine("1. Display list of books");
    Console.WriteLine("2. Search for a book by author");
    Console.WriteLine("3. Search for a book by title keyword");
    Console.WriteLine("4. Return a book");
    Console.WriteLine("5. Check a book out");
    Console.WriteLine("6. Exit Application");

    if (!int.TryParse(Console.ReadLine(), out userSelection))
    {
        Console.WriteLine("Please enter a valid number from our Catalog Menu");
        continue;
    }

    switch (userSelection)
    {
        case 1:
            BookList(bookList);
            break;
        case 2:
            SearchByAuthor(bookList, author);
            break;
        case 3:
            SearchByKeyword(bookList, keyword);
            break;
        case 4:
            ReturnBook(bookList, title, displayDate);
            break;
        case 5:
            CheckOutBook(bookList, displayDate);
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid selection, exiting application.");
            break;
    }
}

static void BookList(List<Book> bookList)
{
    foreach (Book book in bookList)
    {
        Console.WriteLine(book.Title);
        Console.WriteLine(book.Author);
        Console.WriteLine();
    }
}

static void CheckOutBook(List<Book> bookList, string displayDate)
{
    Console.WriteLine("Please enter the title of the book you'd like to checkout:");
    string title = Console.ReadLine();
    var checkOutBook = bookList.FirstOrDefault(x => x.Title.ToLower().Trim() == title.ToLower().Trim());

    if (checkOutBook.Status == "on shelf")
    {
        Console.WriteLine($"You've checkout out {title}. The book is due {displayDate}");
    }
    else if (checkOutBook.Status == "checked out")
    {
        Console.WriteLine("Sorry, this book is currently checked out.");
    }
    else
    {
        Console.WriteLine("No book of this name in the library catalog");
    }
}

// Search for a book by author
static void SearchByAuthor(List<Book> bookList, string author)
{
    Console.WriteLine("Please enter the author of the book:");
    author = Console.ReadLine();
    foreach (var book in bookList)
    {
        if (book.Title == author.ToLower().Trim())
        {
            Console.WriteLine(bookList.Where(x => x.Author == author.ToLower().Trim()));
        }
        else
        {
            Console.WriteLine("There are no books with that author in the library's database.");
        }
        
    }
}

// Search for a book by title keyword
static void SearchByKeyword(List<Book> bookList, string keyword)
{
    Console.WriteLine("Please enter the keyword to search book titles:");
    keyword = Console.ReadLine();

    foreach (var book in bookList)
    {
        if (book.Title.Contains(keyword))
        {
            Console.WriteLine(bookList.Where(x => x.Title.Contains(keyword.ToLower().Trim())));
        }
        else
        {
            Console.WriteLine("There are no books that contain that keyword in the library's database.");
        }
    }
}

// Return a book. (You can decide how that looks/what questions it asks.)
static void ReturnBook(List<Book> bookList, string title, string displayDate)
{
    Console.WriteLine("Please enter the title of the book you'd like to return:");
    title = Console.ReadLine();

    foreach (var book in bookList)
    {
        if (book.Title == title.ToLower().Trim())
        {
            Console.WriteLine(book.Title, book.Author, book.Status);
            if (book.Status == "on shelf")
            {
                Console.WriteLine("This book is already on the shelf.");
            }
            else if (book.Status == "checked out")
            {
                book.Status = "on shelf";
                Console.WriteLine($"You've returned out {title}.");
            }
            else
            {
                Console.WriteLine("There are no books that contain that keyword in the library's database.");
            }
        }
        else
        {
            Console.WriteLine("There are no books with that title in the library's database.");
        }
    }
}