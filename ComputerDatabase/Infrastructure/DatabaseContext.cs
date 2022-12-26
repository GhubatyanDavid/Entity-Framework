using Microsoft.EntityFrameworkCore;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Battles> Battles { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<IncomeO> IncomeO { get; set; }
        public virtual DbSet<Laptop> Laptop { get; set; }
        public virtual DbSet<Outcome> Outcome { get; set; }
        public virtual DbSet<OutcomeO> OutcomeO { get; set; }
        public virtual DbSet<Outcomes> Outcomes { get; set; }
        public virtual DbSet<PassInTrip> PassInTrip { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<Pc> Pc { get; set; }
        public virtual DbSet<Printer> Printer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<Trip> Trip { get; set; }
        public virtual DbSet<UtB> UtB { get; set; }
        public virtual DbSet<UtQ> UtQ { get; set; }
        public virtual DbSet<UtV> UtV { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=sql-ex;Trusted_Connection=True;");
                optionsBuilder.LogTo(Console.WriteLine);


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Battles>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.Class);

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bore).HasColumnName("bore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Displacement).HasColumnName("displacement");

                entity.Property(e => e.NumGuns).HasColumnName("numGuns");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdComp)
                    .HasName("PK2");

                entity.Property(e => e.IdComp)
                    .HasColumnName("ID_comp")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inc)
                    .HasColumnName("inc")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Point).HasColumnName("point");
            });

            modelBuilder.Entity<IncomeO>(entity =>
            {
                entity.HasKey(e => new { e.Point, e.Date });

                entity.ToTable("Income_o");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inc)
                    .HasColumnName("inc")
                    .HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Hd).HasColumnName("hd");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Ram).HasColumnName("ram");

                entity.Property(e => e.Screen).HasColumnName("screen");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.HasOne(d => d.ModelNavigation)
                    .WithMany(p => p.Laptop)
                    .HasForeignKey(d => d.Model)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Laptop_product");

            });

            modelBuilder.Entity<Outcome>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Out)
                    .HasColumnName("out")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Point).HasColumnName("point");
            });

            modelBuilder.Entity<OutcomeO>(entity =>
            {
                entity.HasKey(e => new { e.Point, e.Date });

                entity.ToTable("Outcome_o");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Out)
                    .HasColumnName("out")
                    .HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Outcomes>(entity =>
            {
                entity.HasKey(e => new { e.Ship, e.Battle });

                entity.Property(e => e.Ship)
                    .HasColumnName("ship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Battle)
                    .HasColumnName("battle")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.BattleNavigation)
                    .WithMany(p => p.Outcomes)
                    .HasForeignKey(d => d.Battle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Outcomes_Battles");
            });

            modelBuilder.Entity<PassInTrip>(entity =>
            {
                entity.HasKey(e => new { e.TripNo, e.Date, e.IdPsg })
                    .HasName("PK_pt");

                entity.ToTable("Pass_in_trip");

                entity.Property(e => e.TripNo).HasColumnName("trip_no");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPsg).HasColumnName("ID_psg");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdPsgNavigation)
                    .WithMany(p => p.PassInTrip)
                    .HasForeignKey(d => d.IdPsg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pass_in_trip_Passenger");

                entity.HasOne(d => d.TripNoNavigation)
                    .WithMany(p => p.PassInTrip)
                    .HasForeignKey(d => d.TripNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pass_in_trip_Trip");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.HasKey(e => e.IdPsg)
                    .HasName("PK_psg");

                entity.Property(e => e.IdPsg)
                    .HasColumnName("ID_psg")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pc>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_pc");

                entity.ToTable("PC");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cd)
                    .IsRequired()
                    .HasColumnName("cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hd).HasColumnName("hd");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Ram).HasColumnName("ram");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.HasOne(d => d.ModelNavigation)
                    .WithMany(p => p.Pc)
                    .HasForeignKey(d => d.Model)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pc_product");
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_printer");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModelNavigation)
                    .WithMany(p => p.Printer)
                    .HasForeignKey(d => d.Model)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_printer_product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Model)
                    .HasName("PK_product");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasColumnName("maker")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasColumnName("class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Launched).HasColumnName("launched");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.Ships)
                    .HasForeignKey(d => d.Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ships_Classes");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.HasKey(e => e.TripNo)
                    .HasName("PK_t");

                entity.Property(e => e.TripNo)
                    .HasColumnName("trip_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdComp).HasColumnName("ID_comp");

                entity.Property(e => e.Plane)
                    .IsRequired()
                    .HasColumnName("plane")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TimeIn)
                    .HasColumnName("time_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("time_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.TownFrom)
                    .IsRequired()
                    .HasColumnName("town_from")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TownTo)
                    .IsRequired()
                    .HasColumnName("town_to")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCompNavigation)
                    .WithMany(p => p.Trip)
                    .HasForeignKey(d => d.IdComp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trip_Company");
            });

            modelBuilder.Entity<UtB>(entity =>
            {
                entity.HasKey(e => new { e.BDatetime, e.BQId, e.BVId });

                entity.ToTable("utB");

                entity.Property(e => e.BDatetime)
                    .HasColumnName("B_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.BQId).HasColumnName("B_Q_ID");

                entity.Property(e => e.BVId).HasColumnName("B_V_ID");

                entity.Property(e => e.BVol).HasColumnName("B_VOL");

                entity.HasOne(d => d.BQ)
                    .WithMany(p => p.UtB)
                    .HasForeignKey(d => d.BQId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_utB_utQ");

                entity.HasOne(d => d.BV)
                    .WithMany(p => p.UtB)
                    .HasForeignKey(d => d.BVId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_utB_utV");
            });

            modelBuilder.Entity<UtQ>(entity =>
            {
                entity.HasKey(e => e.QId);

                entity.ToTable("utQ");

                entity.Property(e => e.QId)
                    .HasColumnName("Q_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.QName)
                    .IsRequired()
                    .HasColumnName("Q_NAME")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtV>(entity =>
            {
                entity.HasKey(e => e.VId);

                entity.ToTable("utV");

                entity.Property(e => e.VId)
                    .HasColumnName("V_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.VColor)
                    .IsRequired()
                    .HasColumnName("V_COLOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VName)
                    .IsRequired()
                    .HasColumnName("V_NAME")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
