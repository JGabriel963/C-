namespace FirstAPI.Repository.Interfaces;

public interface ILibraryRepository
{
    Book Add(Book book);
    List<Book> GetAll();
    Book? GetById(int id);
    Book? Update(int id, Book updated);
    bool Delete(int id);
}
