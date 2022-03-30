using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_locations.Models
{
    public class City
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string city_name { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal latitude { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal longitude { get; set; }

        [ForeignKey("country_id")]
        public Country Country { get; set; }
        public int country_id { get; set; }
    }
}
