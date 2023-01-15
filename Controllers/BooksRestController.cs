using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksRestController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksRestController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/BooksRest/GetAllBookStoredProcedure
        [HttpGet("GetAllBookStoredProcedure")]
        public ActionResult<IEnumerable<Book>> GetAllBookStoredProcedure()
        {
            var books = _bookService.GetAllBookStoredProcedure();

            return books;
        }

        // GET: api/BooksRest/GetCategories
        [HttpGet("GetCategories")]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            var ctegories = _bookService.GetCategories();

            return ctegories;
        }

        // GET: api/BooksRest/GetSubCategories/1
        [HttpGet("GetSubCategories/{Id}")]
        public ActionResult<IEnumerable<Category>> GetSubCategories(int id)
        {
            var subCategories = _bookService.GetSubCategories(id);

            return subCategories;
        }

        // GET: api/BooksRest/GetBooks/1
        [HttpGet("GetBooks/{CategoryId}")]
        public JsonResult GetBooks(int CategoryId)
        {
            var books = _bookService.GetBooks(CategoryId);

            return new JsonResult(books);
        }



        // GET: api/BooksRest/GetAllBookEF
        [HttpGet("GetAllBookEF")]
        public ActionResult<IEnumerable<Book>> GetAllBookEF()
        {
            var books = _bookService.GetAllBookEF();

            return books;
        }
    }
}
