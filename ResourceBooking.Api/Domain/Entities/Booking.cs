namespace ResourceBooking.Api.Domain.Entities;

public class Booking
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Resource Resource { get; set; } = null!;
}