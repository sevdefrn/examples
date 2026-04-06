using System;
using System.Collections.Generic;

namespace HotelApp_Data.Models;

public partial class HotelImage
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool IsMain { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;
}
