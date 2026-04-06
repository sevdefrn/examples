using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class VwRoomDetail
{
    public int HotelRoomId { get; set; }

    public int HotelId { get; set; }

    public string HotelName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string RoomTypeName { get; set; } = null!;

    public int MaxGuests { get; set; }

    public decimal PricePerNight { get; set; }

    public int TotalRooms { get; set; }

    public bool IsActive { get; set; }
}
