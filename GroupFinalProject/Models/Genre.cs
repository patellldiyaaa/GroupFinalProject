
using GroupFinalProject.Models;
using System.ComponentModel.DataAnnotations;

namespace GroupFinalProject.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Required]
        [StringLength(50)]
        public string GenreName { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; }
            = new List<Movie>();
    }
}
