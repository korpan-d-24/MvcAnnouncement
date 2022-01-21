using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAnnouncement.Models
{
    public class AnnouncementGenreViewModel
    {
        public List<Announcement> Announcements { get; set; }

        public SelectList Genres { get; set; }

        public string AnnouncementGerne { get; set; }

        public string SearchString { get; set; }
    }
}
