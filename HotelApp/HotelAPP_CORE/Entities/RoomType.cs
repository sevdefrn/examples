using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class RoomType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int MaxGuests { get; set; }

    public virtual ICollection<HotelRoom> HotelRooms { get; set; } = new List<HotelRoom>();
}
