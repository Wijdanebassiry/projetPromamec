using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetPromamec.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Client")]
        public required string ClientName { get; set; }

        [Display(Name = "Contact")]
        public required string ContactPhone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime ProjectDate { get; set; } = DateTime.Today;

        [Display(Name = "N° Projet")]
        public required string ProjectNumber { get; set; }

        // Add all other fields from your form
        public required string FilePath { get; set; } // For uploaded files
    }
}