using FirstAPI.Repository.Interfaces;

namespace FirstAPI.Repository;

public class LibraryRepository: ILibraryRepository
{
    public List<Book> Books { get; set; } = new List<Book>();

    public Book Add(Book book)
    {
        book.Id = Books.Count > 0 ? Books.Max(b => b.Id) + 1 : 1;
        Books.Add(book);
        return book;
    }

    public List<Book> GetAll() => Books;

    public Book? GetById(int id) => Books.FirstOrDefault(b => b.Id == id);

    public Book? Update(int id, Book updated)
    {
        var book = GetById(id);
        if (book is null) return null;

        book.title = updated.title;
        return book;
    }

    // DELETE
    public bool Delete(int id)
    {
        var book = GetById(id);
        if (book is null) return false;

        Books.Remove(book);
        return true;
    }

}
