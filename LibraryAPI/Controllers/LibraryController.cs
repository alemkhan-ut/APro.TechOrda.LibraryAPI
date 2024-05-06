using LibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        [HttpGet("Books")]
        public IResult GetBooks()
        {
            BookRepository bookRepository = new BookRepository();

            bookRepository.Books.Add(
                new Book()
                {
                    Title = "Book 1",
                    Author = "Author 1",
                    Description = "Desc 1",
                    PublishDate = new DateOnly(2024, 01, 22)
                });

            return Results.Ok(bookRepository.Books);
        }
    }
}
