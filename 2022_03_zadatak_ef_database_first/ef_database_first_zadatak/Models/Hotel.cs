namespace ef_database_first_zadatak.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Sobas = new HashSet<Soba>();
        }

        public int IdHotela { get; set; }
        public string Naziv { get; set; } = null!;
        public string Adresa { get; set; } = null!;
        public string Grad { get; set; } = null!;
        public byte BrojZvjezdica { get; set; }

        public virtual ICollection<Soba> Sobas { get; set; }
    }
}
