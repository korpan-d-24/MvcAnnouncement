using System;
using System.ComponentModel.DataAnnotations;

namespace MvcAnnouncement.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        [Display(Name = "Rating (5 out of 7 is best!)")]

        public string Rating { get; set; }
    }
}
