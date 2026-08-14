using System.ComponentModel.DataAnnotations;
using ResourceBooking.Api.Domain.Enums;

namespace ResourceBooking.Api.Contracts.Resources;

public sealed class UpdateResourceRequest
{
    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    public ResourceType Type { get; set; }

    [Range(1, int.MaxValue)]
    public int Capacity { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public bool IsActive { get; set; }
}