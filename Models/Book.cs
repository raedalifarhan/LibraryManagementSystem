using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    [Table("Book", Schema= "LIB" )]
    public class Book
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Book Description")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "File URL")]
        public string FileUrl { get; set; } = string.Empty;

        [Display(Name = "Image Cover URL")]
        public string? ImageCoverUrl { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Last Update Date")]
        public DateTime LastUpdatedAt { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }


        //Related Codes

        public int PublisherID { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Author>? authors { get; set; }
    }
}
