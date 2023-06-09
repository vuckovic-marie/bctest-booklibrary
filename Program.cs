using BookLibrary;
using BookLibrary.Services;

Console.WriteLine("Hello, there!");
Console.WriteLine("Do you want to get all the books from the library? (Y/N)");
string? answer = Console.ReadLine();
if (answer?.ToLower() == "y")
{
    try
    {
        List<Book> initBookList = await new BookService().GetAllBooks();
        List<List<Book>> filteredBookList = await new BookService().FilterBooks(initBookList);
        if (filteredBookList.Any())
        {
            string bookset = string.Empty;
            foreach (var bookList in filteredBookList)
            {
                bookset += bookList.FirstOrDefault().parent_name + Environment.NewLine;
                foreach (var book in bookList)
                {
                    bookset += book.display_name + " " + String.Join(",", book.meta.states) + Environment.NewLine;
                }
            }
            new BookService().SaveBooks(bookset);
        }
        Console.WriteLine("All done! Check project folder for books.txt for data on books.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    Console.ReadLine();
}


