using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Services
{
    public interface IBookService
    {

        // I can use Generic To use some of this methods with any Entity.
        public List<Category> GetCategories();

        public List<Category> GetSubCategories(int id);

        public List<Book> GetAllBookStoredProcedure();

        public List<Book> GetAllBookEF();

        public List<Book> GetBooks(int id);

    }
}
