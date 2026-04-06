using System;
using System.Collections.Generic;

namespace HotelApp_Core.Entities;

public partial class Log
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Level { get; set; } = null!;

    public string Message { get; set; } = null!;

    public int? UserId { get; set; }

    public string? UserEmail { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public string? IpAddress { get; set; }

    public string? ExceptionDetail { get; set; }

    public virtual User? User { get; set; }
}
