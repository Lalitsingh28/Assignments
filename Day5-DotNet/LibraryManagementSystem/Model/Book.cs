using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Author Author { get; set; }
    }
}
