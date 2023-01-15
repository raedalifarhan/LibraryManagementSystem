using LibraryManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: Books
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCategories()
        {

            var ctegories = _bookService.GetCategories();

            return new JsonResult(ctegories);
        }

        public JsonResult GetSubCategories(int id)
        {
            var subCategories = _bookService.GetSubCategories(id);

            return new JsonResult(subCategories);
        }

        public JsonResult GetBooks(int id)
        {
            var books = _bookService.GetBooks(id);

            return new JsonResult(books);
        }



        public IActionResult GetAllBookStoredProcedure()
        {
            var books = _bookService.GetAllBookStoredProcedure();

            return View(books);
        }

        public IActionResult GetAllBookEF()
        {
            var books = _bookService.GetAllBookEF();

            return View(books);
        }


    }
}
