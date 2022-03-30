namespace ef_database_first_zadatak.Models
{
    public partial class Zauzece
    {
        public int IdZauzeca { get; set; }
        public int SobaId { get; set; }
        public int GostId { get; set; }
        public int BrojGostiju { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

        public virtual Gost Gost { get; set; } = null!;
        public virtual Soba Soba { get; set; } = null!;
    }
}
