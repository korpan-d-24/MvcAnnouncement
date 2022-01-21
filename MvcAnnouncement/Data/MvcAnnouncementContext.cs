using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAnnouncement.Models;

namespace MvcAnnouncement.Data
{
    public class MvcAnnouncementContext : DbContext
    {
        public MvcAnnouncementContext (DbContextOptions<MvcAnnouncementContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAnnouncement.Models.Announcement> Announcement { get; set; }
    }
}
