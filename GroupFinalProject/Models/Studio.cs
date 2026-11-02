
using GroupFinalProject.Models;
using System.ComponentModel.DataAnnotations;

namespace GroupFinalProject.Models
{
    public class Studio
    {
        public int StudioID { get; set; }

        [Required]
        [StringLength(100)]
        public string StudioName { get; set; } = string.Empty;

        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; }
            = new List<Movie>();
    }
}
