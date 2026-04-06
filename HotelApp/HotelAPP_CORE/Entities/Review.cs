using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class Review
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public int UserId { get; set; }

    public byte Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
