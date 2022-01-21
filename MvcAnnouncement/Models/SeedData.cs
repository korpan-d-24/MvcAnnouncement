using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcAnnouncement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAnnouncement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAnnouncementContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcAnnouncementContext>>()))
            {
                if (context.Announcement.Any())
                {
                    return;
                }

                context.Announcement.AddRange(
                    new Announcement 
                    {
                        Title = "Circus performance",
                        ReleaseDate = DateTime.Parse("2022-01-20"),
                        Genre = "Comedy",
                        Description = "Come and see the wonders of acrobatics, the funniest clowns and performances with animals"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
