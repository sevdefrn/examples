using System;
using System.Collections.Generic;
using HotelApp_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp_Data.Contexts;

public partial class HotelAppDbContext : DbContext
{
    public HotelAppDbContext()
    {
    }

    public HotelAppDbContext(DbContextOptions<HotelAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Amenity> Amenities { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelImage> HotelImages { get; set; }

    public virtual DbSet<HotelRoom> HotelRooms { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VwHotelSummary> VwHotelSummaries { get; set; }

    public virtual DbSet<VwRoomDetail> VwRoomDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=HotelAppDB;User Id=sa;Password=StrongPassword123!;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Amenity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Amenitie__3214EC07292B64C9");

            entity.HasIndex(e => e.Name, "UQ__Amenitie__737584F644162CAE").IsUnique();

            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hotels__3214EC0758A3C812");

            entity.HasIndex(e => e.City, "IX_Hotels_City");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AvgRating).HasColumnType("decimal(3, 1)");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasMany(d => d.Amenities).WithMany(p => p.Hotels)
                .UsingEntity<Dictionary<string, object>>(
                    "HotelAmenity",
                    r => r.HasOne<Amenity>().WithMany()
                        .HasForeignKey("AmenityId")
                        .HasConstraintName("FK_HotelAmenities_Amenities"),
                    l => l.HasOne<Hotel>().WithMany()
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_HotelAmenities_Hotels"),
                    j =>
                    {
                        j.HasKey("HotelId", "AmenityId").HasName("PK__HotelAme__EE40948F566E73EF");
                        j.ToTable("HotelAmenities");
                    });
        });

        modelBuilder.Entity<HotelImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HotelIma__3214EC07DDB53325");

            entity.Property(e => e.ImageUrl).HasMaxLength(500);

            entity.HasOne(d => d.Hotel).WithMany(p => p.HotelImages)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_HotelImages_Hotels");
        });

        modelBuilder.Entity<HotelRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HotelRoo__3214EC07807AF647");

            entity.HasIndex(e => e.HotelId, "IX_HotelRooms_HotelId");

            entity.HasIndex(e => e.RoomTypeId, "IX_HotelRooms_RoomTypeId");

            entity.HasIndex(e => new { e.HotelId, e.RoomTypeId }, "UQ_HotelRooms").IsUnique();

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PricePerNight).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Hotel).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_HotelRooms_Hotels");

            entity.HasOne(d => d.RoomType).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK_HotelRooms_RoomTypes");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logs__3214EC07B27D2504");

            entity.HasIndex(e => e.Level, "IX_Logs_Level");

            entity.HasIndex(e => e.Timestamp, "IX_Logs_Timestamp").IsDescending();

            entity.HasIndex(e => e.UserId, "IX_Logs_UserId");

            entity.Property(e => e.Action).HasMaxLength(200);
            entity.Property(e => e.Controller).HasMaxLength(100);
            entity.Property(e => e.ExceptionDetail).HasMaxLength(4000);
            entity.Property(e => e.IpAddress).HasMaxLength(45);
            entity.Property(e => e.Level).HasMaxLength(20);
            entity.Property(e => e.Message).HasMaxLength(2000);
            entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserEmail).HasMaxLength(200);

            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Logs_User");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservat__3214EC075385E403");

            entity.HasIndex(e => new { e.CheckInDate, e.CheckOutDate }, "IX_Reservations_Dates");

            entity.HasIndex(e => e.HotelRoomId, "IX_Reservations_HotelRoomId");

            entity.HasIndex(e => e.UserId, "IX_Reservations_UserId");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.GuestCount).HasDefaultValue(1);
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.HotelRoom).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.HotelRoomId)
                .HasConstraintName("FK_Reservation_HotelRoomId");

            entity.HasOne(d => d.User).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reservation_Users");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reviews__3214EC0703E94C15");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateHotelRating"));

            entity.HasIndex(e => e.HotelId, "IX_Reviews_HotelId");

            entity.HasIndex(e => new { e.UserId, e.HotelId }, "UQ_Reviews_UserHotel").IsUnique();

            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_Reviews_Hotels");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reviews_Users");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC07F68931E6");

            entity.HasIndex(e => e.Name, "UQ_Roles_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RoomType__3214EC07A9F96CFD");

            entity.HasIndex(e => e.Name, "UQ_RoomTypes_Name").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MaxGuests).HasDefaultValue(2);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07A83D89E6");

            entity.HasIndex(e => e.Email, "IX_Users_Email");

            entity.HasIndex(e => e.Email, "UQ_Users_Email").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmailVerificationToken).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserRoles_Role"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserRoles_User"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("UserRoles");
                    });
        });

        modelBuilder.Entity<VwHotelSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HotelSummary");

            entity.Property(e => e.AvgRating).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.MinPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VwRoomDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RoomDetails");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.HotelName).HasMaxLength(200);
            entity.Property(e => e.PricePerNight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoomTypeName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
