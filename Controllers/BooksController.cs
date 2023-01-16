using AutoMapper;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BooksController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        // GET: Books
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCategories()
        {
            return new JsonResult(
                _mapper.Map<List<CategoryViewModel>>(
                    _bookService.GetCategories()
                ));
        }

        public JsonResult GetSubCategories(int id)
        {


            return new JsonResult(
                _mapper.Map<List<CategoryViewModel>>(
                    _bookService.GetSubCategories(id)
                ));
        }

        public JsonResult GetBooks(int id)
        {
            return new JsonResult(
                _mapper.Map<List<BookViewModel>>(
                    _bookService.GetBooks(id)
                ));
        }

        public IActionResult GetAllBookStoredProcedure()
        {
            return View(
                _mapper.Map<List<BookViewModel>>(
                    _bookService.GetAllBookStoredProcedure()
                ));
        }

        public IActionResult GetAllBookEF()
        {
            return View(
                _mapper.Map<List<BookViewModel>>(
                    _bookService.GetAllBookEF()
                ));
        }
    }
}
