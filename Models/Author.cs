using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace LibraryManagementSystem.Models
{
    [Table("Author", Schema = "LIB")]
    public class Author
    {
        [Key]
        [Display(Name="Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Author Name")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Book>? Books { get; set; }
    }
}
