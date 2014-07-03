namespace Mars.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarsDbModel : DbContext
    {
        public MarsDbModel()
            : base("name=MarsDbModel")
        {
        }

        public virtual DbSet<Doktori> Doktori { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Prezenteri> Prezenteri { get; set; }
        public virtual DbSet<Rabotilnici> Rabotilnici { get; set; }
        public virtual DbSet<RabotilniciDoktori> RabotilniciDoktori { get; set; }
        public virtual DbSet<RabotilniciPrezenteri> RabotilniciPrezenteri { get; set; }
        public virtual DbSet<Temi> Temi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doktori>()
                .Property(e => e.DoktorFaksimil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Doktori>()
                .HasMany(e => e.RabotilniciDoktori)
                .WithRequired(e => e.Doktori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gradovi>()
                .HasMany(e => e.Rabotilnici)
                .WithRequired(e => e.Gradovi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prezenteri>()
                .Property(e => e.PrezenterFaksimil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prezenteri>()
                .HasMany(e => e.RabotilniciPrezenteri)
                .WithRequired(e => e.Prezenteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rabotilnici>()
                .Property(e => e.Pocetok)
                .HasPrecision(0);

            modelBuilder.Entity<Rabotilnici>()
                .Property(e => e.Kraj)
                .HasPrecision(0);

            modelBuilder.Entity<Rabotilnici>()
                .HasMany(e => e.RabotilniciDoktori)
                .WithRequired(e => e.Rabotilnici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rabotilnici>()
                .HasMany(e => e.RabotilniciPrezenteri)
                .WithRequired(e => e.Rabotilnici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RabotilniciDoktori>()
                .Property(e => e.DoktorFaksimil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RabotilniciPrezenteri>()
                .Property(e => e.PrezenterFaksimil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Temi>()
                .HasMany(e => e.Rabotilnici)
                .WithRequired(e => e.Temi)
                .WillCascadeOnDelete(false);
        }
    }
}
