using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_locations.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }

        public string country_name { get; set; }

        public string country_name_eng { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string country_code { get; set; }
    }
}
