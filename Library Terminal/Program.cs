﻿using Library_Terminal;
using System.Reflection.Metadata.Ecma335;
using static System.Reflection.Metadata.BlobBuilder;

DateTime today = DateTime.Today;
DateTime twoWeeksFromToday = today.AddDays(14);
string displayDate = twoWeeksFromToday.ToString("yyyy-MM-dd");

List<Book> bookList = new List<Book>()
{
    new Book("To Kill a Mockingbird", "Harper Lee", "checked out"),
    new Book("1984", "George Orwell", "on shelf"),
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "on shelf"),
    new Book("Pride and Prejudice", "Jane Austen", "on shelf"),
    new Book("The Catcher in the Rye", "J.D. Salinger", "on shelf"),
    new Book("The Hobbit", "J.R.R. Tolkien", "on self"),
    new Book("The Lord of the Rings", "J.R.R. Tolkien", "on shelf"),
    new Book("Moby-Dick", "Herman Melville", "on self"),
    new Book("The Adventures of Huckleberry Finn", "Mark Twain", "on shelf"),
    new Book("The Grapes of Wrath", "John Steinbeck", "on self"),
    new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "checked out"),
    new Book("Frankenstein", "Mary Shelley", "checked out"),
};


Console.WriteLine("Welcome to our Library! We have an extensive catalog of books for rent.");

while (true)
{
    Console.WriteLine("\nPlease select an option from our Library Catalog Menu:");
    Console.WriteLine("1. Display list of books");
    Console.WriteLine("2. Search for a book by author");
    Console.WriteLine("3. Search for a book by title keyword");
    int userSelection = 0;
    if (!int.TryParse(Console.ReadLine(), out userSelection))
    {
        Console.WriteLine("Please enter a valid number from our Catalog Menu");
        continue;
    }

    switch (userSelection)
    {
        case 1:
            Console.WriteLine();
            break;
                case 2:
            Console.WriteLine();
            break;
                case 3:
            Console.WriteLine();
            break;
        default:
            Console.WriteLine();
            break;
    }


}

static  void BookList()
{
    foreach (var book in bookList)
    {
        Console.WriteLine(book.Title, book.Author);
    }
}





//use linq to search List by usersearch. List<Book> userPick = books.Where(x => x.Author.ToLower().Trim() == userSearch).ToList();
//List<Book> userPick = books.Where(x => x.Title.ToLower().Trim() == userSearch).ToList();
// loop through books to select desired outcome: foreach (Book book in userPick) { Console.WriteLine(book.Author) }
//foreach (Book book in userPick) { Console.WriteLine(book.Title) }




