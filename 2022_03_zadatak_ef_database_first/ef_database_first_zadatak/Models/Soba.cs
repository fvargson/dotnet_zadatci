namespace ef_database_first_zadatak.Models
{
    public partial class Soba
    {
        public Soba()
        {
            Zauzeces = new HashSet<Zauzece>();
        }

        public int IdSobe { get; set; }
        public string Oznaka { get; set; } = null!;
        public int Kapacitet { get; set; }
        public int HotelId { get; set; }

        public virtual Hotel Hotel { get; set; } = null!;
        public virtual ICollection<Zauzece> Zauzeces { get; set; }
    }
}
