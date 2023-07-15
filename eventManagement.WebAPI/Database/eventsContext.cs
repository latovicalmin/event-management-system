using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eventManagement.WebAPI.Database
{
    public partial class eventsContext : DbContext
    {
        public eventsContext()
        {
        }

        public eventsContext(DbContextOptions<eventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<EventCategories> EventCategories { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Participants> Participants { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Speakers> Speakers { get; set; }
        public virtual DbSet<UserOrganizations> UserOrganizations { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=130074;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CountryId");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__Comments__C3B4DFCA09611D3B");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comments__EventI__3E52440B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comments__UserId__3F466844");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EventCategories>(entity =>
            {
                entity.HasKey(e => e.EventCategoryId)
                    .HasName("PK__EventCat__7174DEBE9C9DD698");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.EventCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventCate__Categ__403A8C7D");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventCategories)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventCate__Event__412EB0B6");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Coatization).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaxPlaces).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizationId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("CategoryId");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CityId");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrganizationId");
            });

            modelBuilder.Entity<Organizations>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Participants>(entity =>
            {
                entity.HasKey(e => e.ParticipantId)
                    .HasName("PK__Particip__7227995EED804F47");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Participa__Event__4316F928");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Participa__UserI__440B1D61");
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__Ratings__FCCDF87C5DC64C7B");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__EventId__44FF419A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__UserId__45F365D3");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Speakers>(entity =>
            {
                entity.HasKey(e => e.SpeakerId)
                    .HasName("PK__Speakers__79E757593EC58356");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Speakers)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Speakers__EventI__46E78A0C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Speakers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Speakers__UserId__47DBAE45");
            });

            modelBuilder.Entity<UserOrganizations>(entity =>
            {
                entity.HasKey(e => e.UserOrganizationId)
                    .HasName("PK__UserOrga__FFFA4CE8FDAF785D");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.UserOrganizations)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserOrgan__Organ__48CFD27E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOrganizations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserOrgan__UserI__49C3F6B7");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK__UserRole__3D978A35CF16BB3E");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRoles__RoleI__4AB81AF0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRoles__UserI__4BAC3F29");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20);
            });
        }
    }
}
