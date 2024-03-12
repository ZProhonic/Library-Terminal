string userSearch = "";

Console.WriteLine("Welcome to our Library! We have an extensive catalog of books for rent.");
Console.WriteLine("There are a few options to select a book of your choice. Please select one of the following:");
Console.WriteLine("1. Display list of books 2. Search for a book by author 3. Search for a book by title keyword");

int userSelection = 0;
bool continueLooping = true;

while (continueLooping)
{
    try
    {
        string input = Console.ReadLine();
        userSelection = int.Parse(input);
        continueLooping = false;
    }
    catch (FormatException ex) 
    {
        Console.WriteLine("Please enter a valid option");
    }

}
while (true)
{
    if (userSelection == 1)
    {
        Console.WriteLine(); //loop through List of books
        break;
    }
    else if (userSelection == 2)
    {
        Console.WriteLine("Please enter the name of the author");
        userSearch = Console.ReadLine().ToLower().Trim();
        break;
    }
    else if (userSelection == 3)
    {
        Console.WriteLine("Please enter a book title keyword");
        userSearch = Console.ReadLine().ToLower().Trim();
        break;
    }
    else
    {
        Console.WriteLine("Please pick a way to search for a book");
    }
}


//use linq to search List by usersearch. List<Book> userPick = books.Where(x => x.Author.ToLower().Trim() == userSearch).ToList();
//List<Book> userPick = books.Where(x => x.Title.ToLower().Trim() == userSearch).ToList();
// loop through books to select desired outcome: foreach (Book book in userPick) { Console.WriteLine(book.Author) }
//foreach (Book book in userPick) { Console.WriteLine(book.Title) }




