using System;
using System.Collections.Generic;

namespace HotelApp_Data.Models;

public partial class Amenity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Icon { get; set; }

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
