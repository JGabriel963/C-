using FirstAPI.Repository;
using FirstAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly ILibraryRepository _repository;

    public BookController(ILibraryRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Book>> GetAll() => Ok(_repository.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Book> GetById(int id)
    {
        var book = _repository.GetById(id);
        return book is null ? NotFound() : Ok(book);
    }

    [HttpPost]
    public ActionResult<Book> Add(Book book)
    {
        var created = _repository.Add(book);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public ActionResult<Book> Update(int id, Book book)
    {
        var updated = _repository.Update(id, book);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id) =>
        _repository.Delete(id) ? NoContent() : NotFound();
}
