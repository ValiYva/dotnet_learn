using MegicVilla_VillaAPI1.Models;
using Microsoft.EntityFrameworkCore;

namespace MegicVilla_VillaAPI1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is the description of the Royal Villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = new DateTime(2026, 7, 14, 13, 24, 45, 689, DateTimeKind.Local).AddTicks(6303)
                },
                   new Villa()
                   {
                       Id = 2,
                       Name = "Premium Pool Villa",
                       Details = "This is the description of the Royal Villa",
                       ImageUrl = "",
                       Occupancy = 5,
                       Rate = 300,
                       Sqft = 550,
                       Amenity = "",
                       CreatedDate = new DateTime(2026, 7, 14, 13, 24, 45, 689, DateTimeKind.Local).AddTicks(6303)
                   },
                      new Villa()
                      {
                          Id = 3,
                          Name = "Luxury Pool Villa",
                          Details = "This is the description of the Royal Villa",
                          ImageUrl = "",
                          Occupancy = 5,
                          Rate = 400,
                          Sqft = 750,
                          Amenity = "",
                          CreatedDate = new DateTime(2026, 7, 14, 13, 24, 45, 689, DateTimeKind.Local).AddTicks(6303)
                      },
                         new Villa()
                         {
                             Id = 4,
                             Name = "Diamond Villa",
                             Details = "This is the description of the Royal Villa",
                             ImageUrl = "",
                             Occupancy = 4,
                             Rate = 550,
                             Sqft = 900,
                             Amenity = "",
                             CreatedDate = new DateTime(2026, 7, 14, 13, 24, 45, 689, DateTimeKind.Local).AddTicks(6303)
                         },
                            new Villa()
                            {
                                Id = 5,
                                Name = "Diamond Pool Villa",
                                Details = "This is the description of the Royal Villa",
                                ImageUrl = "",
                                Occupancy = 4,
                                Rate = 600,
                                Sqft = 1100,
                                Amenity = "",
                                CreatedDate = new DateTime(2026, 7, 14, 13, 24, 45, 689, DateTimeKind.Local).AddTicks(6303)
        });
        }
    }
}
