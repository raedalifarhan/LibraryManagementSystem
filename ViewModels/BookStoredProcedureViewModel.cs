using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ViewModels
{
    public class BookStoredProcedureViewModel
    {
        private string CategoryName { get; set; }

        public string AuthorName { get; set; }

        public string TitleName { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}