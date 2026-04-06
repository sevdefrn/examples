using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class Reservation
{
    public int Id { get; set; }

    public int HotelRoomId { get; set; }

    public int UserId { get; set; }

    public DateOnly CheckInDate { get; set; }

    public DateOnly CheckOutDate { get; set; }

    public int GuestCount { get; set; }

    public decimal TotalPrice { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual HotelRoom HotelRoom { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
