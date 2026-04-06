using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsEmailVerified { get; set; }

    public string? EmailVerificationToken { get; set; }

    public DateTime? VerificationTokenExpiry { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? LockoutEndTime { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
