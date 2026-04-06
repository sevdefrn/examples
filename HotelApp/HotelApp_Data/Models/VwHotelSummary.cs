using System;
using System.Collections.Generic;

namespace HotelApp_Data.Models;

public partial class VwHotelSummary
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public byte StarRating { get; set; }

    public decimal AvgRating { get; set; }

    public int? ReviewCount { get; set; }

    public decimal? MinPrice { get; set; }

    public bool IsActive { get; set; }
}
