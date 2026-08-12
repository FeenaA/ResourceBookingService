using ResourceBooking.Api.Domain.Enums;

namespace ResourceBooking.Api.Domain.Entities;

public sealed class Resource
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public ResourceType Type { get; set; }

    public int Capacity { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
}