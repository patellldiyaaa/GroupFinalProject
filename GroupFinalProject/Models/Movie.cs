
using System.ComponentModel.DataAnnotations;

namespace GroupFinalProject.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public int Runtime { get; set; }

        public string MPARating { get; set; } = string.Empty;

        public string PosterURL { get; set; } = string.Empty;

        public int GenreID { get; set; }

        public Genre? Genre { get; set; }

        public int DirectorID { get; set; }

        public Director? Director { get; set; }

        public int StudioID { get; set; }

        public Studio? Studio { get; set; }
    }
}
