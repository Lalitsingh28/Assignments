using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class Patron
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string ContactInformation { get; set; }
    }
}
