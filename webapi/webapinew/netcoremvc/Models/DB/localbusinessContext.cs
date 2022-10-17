using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace netcoremvc.Models.DB
{
    public partial class localbusinessContext : DbContext
    {
        public localbusinessContext()
        {
        }

        public localbusinessContext(DbContextOptions<localbusinessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=RAGHUPRASAD;Initial Catalog=localbusiness;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "Userrole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("Roleid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__userrole__roleid__2C3393D0"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("Userid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__userrole__userid__2B3F6F97"),
                        j =>
                        {
                            j.HasKey("Userid", "Roleid").HasName("PK__userrole__F77826E82E37F105");

                            j.ToTable("userrole");

                            j.IndexerProperty<int>("Userid").HasColumnName("userid");

                            j.IndexerProperty<int>("Roleid").HasColumnName("roleid");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
