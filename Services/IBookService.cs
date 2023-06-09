namespace BookLibrary.Services;

public interface IBookService
{
    Task<List<Book>> GetAllBooks();
    Task<List<List<Book>>> FilterBooks(List<Book> bookList);
    void SaveBooks(string Bookset);
}