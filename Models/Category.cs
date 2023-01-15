using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    [Table("Category", Schema = "LIB")]
    public class Category
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        public int SubCategoryId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Book> books { get; set; }
    }
}
