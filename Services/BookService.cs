
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {

        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Book> GetAllBookEF()
        {
            return _context.Books.ToList();
        }

        public List<Book> GetAllBookStoredProcedure()
        {
            return _context.Books.FromSqlRaw($"LIB.GetBooks").ToList();
        }

        public List<Book> GetBooks(int id)
        {
            // id must be named CategoryId (Remember to Edit it)
            return this.GetAllBookEF().Where(b => b.CategoryId == id).ToList();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public List<Category> GetSubCategories(int id)
        {
            return _context.Categories.Where(c => c.SubCategoryId == id).ToList();
        }
    }
}
