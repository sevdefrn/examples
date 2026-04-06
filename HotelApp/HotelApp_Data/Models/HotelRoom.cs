using System;
using System.Collections.Generic;

namespace HotelApp_Data.Models;

public partial class HotelRoom
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public int RoomTypeId { get; set; }

    public decimal PricePerNight { get; set; }

    public int TotalRooms { get; set; }

    public bool IsActive { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual RoomType RoomType { get; set; } = null!;
}
