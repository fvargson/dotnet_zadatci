using Microsoft.EntityFrameworkCore;
using mvc_locations.Models;

namespace mvc_locations.Data
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Zadatak:
        // kreirati metodu OnModelCreating(ModelBuilder modelBuilder)
        // Napraviti seed podataka za:
        // Minimalno dvije nasumične države s pripadajućim podacima
        // minimalno šest nasumičnih gradova s pripadajućim podacima

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country {
                    id = 1,
                    country_name = "Hrvatska",
                    country_name_eng = "Croatia",
                    country_code = "+385-HRV-191"
                },
                new Country {
                    id = 2,
                    country_name = "Ukrajina",
                    country_name_eng = "Ukraine",
                    country_code = "+380-UKR-142"
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City {
                    id = 1,
                    city_name = "Zagreb",
                    latitude = 45.815399M,
                    longitude = 15.966568M,
                    country_id = 1
                },
                new City {
                    id = 2,
                    city_name = "Rijeka",
                    latitude = 45.328979M,
                    longitude =  14.457664M,
                    country_id = 1
                },
                new City {
                    id = 3,
                    city_name = "Vinkovci",
                    latitude = 45.287865M,
                    longitude = 18.802666M,
                    country_id = 1
                },
                new City {
                    id = 4,
                    city_name = "Кiев",
                    latitude = 50.450001M,
                    longitude = 30.523333M,
                    country_id = 2
                },
                new City {
                    id = 5,
                    city_name = "Донецк",
                    latitude = 48.002777M,
                    longitude = 37.805279M,
                    country_id = 2
                },
                new City {
                    id = 6,
                    city_name = "Одесса",
                    latitude = 46.482952M,
                    longitude = 30.712481M,
                    country_id = 2
                }
            );
        }
    }
}
