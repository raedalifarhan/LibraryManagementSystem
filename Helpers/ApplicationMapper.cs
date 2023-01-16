using AutoMapper;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.ViewModels;

namespace LibraryManagementSystem.Helpers
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<Book, BookViewModel>().ReverseMap();
        }
    }
}
