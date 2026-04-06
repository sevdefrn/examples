using System;
using System.Collections.Generic;

namespace HotelApp_Data.Models;

public partial class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public decimal? AvgRating { get; set; }

    public byte StarRating { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<HotelImage> HotelImages { get; set; } = new List<HotelImage>();

    public virtual ICollection<HotelRoom> HotelRooms { get; set; } = new List<HotelRoom>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
}
