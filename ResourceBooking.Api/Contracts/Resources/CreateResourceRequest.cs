using ResourceBooking.Api.Domain.Enums;

namespace ResourceBooking.Api.Contracts.Resources;

public sealed class CreateResourceRequest
{
    public required string Name { get; set; }

    public ResourceType Type { get; set; }

    public int Capacity { get; set; }

    public string? Description { get; set; }
}