using Microsoft.EntityFrameworkCore;

namespace ef_database_first_zadatak.Models
{
    public partial class hotelContext : DbContext
    {
        public hotelContext()
        {
        }

        public hotelContext(DbContextOptions<hotelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gost> Gosts { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<Soba> Sobas { get; set; } = null!;
        public virtual DbSet<Zauzece> Zauzeces { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // add your username and password in connection string down below
                optionsBuilder.UseSqlServer("Server=localhost;Database=hotel;UID=SA;PWD=<**PWD**>;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gost>(entity =>
            {
                entity.HasKey(e => e.IdGosta)
                    .HasName("PK__Gost__FB5F558416FD38B2");

                entity.ToTable("Gost");

                entity.HasIndex(e => e.Oib, "UQ__Gost__CB394B3E32053889")
                    .IsUnique();

                entity.Property(e => e.Ime).HasMaxLength(35);

                entity.Property(e => e.Oib)
                    .HasMaxLength(11)
                    .HasColumnName("OIB");

                entity.Property(e => e.Prezime).HasMaxLength(35);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.IdHotela)
                    .HasName("PK__Hotel__FA1578F67B4BF46A");

                entity.ToTable("Hotel");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.Grad).HasMaxLength(55);

                entity.Property(e => e.Naziv).HasMaxLength(55);
            });

            modelBuilder.Entity<Soba>(entity =>
            {
                entity.HasKey(e => e.IdSobe)
                    .HasName("PK__Soba__ADC8D52D24C5F293");

                entity.ToTable("Soba");

                entity.Property(e => e.Oznaka).HasMaxLength(35);

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Sobas)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Soba__HotelId__4D94879B");
            });

            modelBuilder.Entity<Zauzece>(entity =>
            {
                entity.HasKey(e => e.IdZauzeca)
                    .HasName("PK__Zauzece__333393930FC71317");

                entity.ToTable("Zauzece");

                entity.Property(e => e.DatumDo).HasColumnType("datetime");

                entity.Property(e => e.DatumOd).HasColumnType("datetime");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.Zauzeces)
                    .HasForeignKey(d => d.GostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Zauzece__GostId__5165187F");

                entity.HasOne(d => d.Soba)
                    .WithMany(p => p.Zauzeces)
                    .HasForeignKey(d => d.SobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Zauzece__SobaId__5070F446");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
