namespace ef_database_first_zadatak.Models
{
    public partial class Gost
    {
        public Gost()
        {
            Zauzeces = new HashSet<Zauzece>();
        }

        public int IdGosta { get; set; }
        public string Oib { get; set; } = null!;
        public string Ime { get; set; } = null!;
        public string Prezime { get; set; } = null!;

        public virtual ICollection<Zauzece> Zauzeces { get; set; }
    }
}
