
using GroupFinalProject.Models;
using System.ComponentModel.DataAnnotations;

namespace GroupFinalProject.Models
{
    public class Director
    {
        public int DirectorID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; }
            = new List<Movie>();
    }
}
