using Microsoft.AspNetCore.Mvc;
using ResourceBooking.Api.Domain.Entities;
using ResourceBooking.Api.Domain.Enums;

namespace ResourceBooking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ResourcesController : ControllerBase
{
    private static readonly List<Resource> Resources =
    [
        new Resource
        {
            Id = 1,
            Name = "Meeting Room A",
            Type = ResourceType.MeetingRoom,
            Capacity = 8,
            Description = "Meeting room with a projector",
            IsActive = true
        },
        new Resource
        {
            Id = 2,
            Name = "Projector A",
            Type = ResourceType.Projector,
            Capacity = 1,
            Description = "Portable projector",
            IsActive = true
        }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Resource>> GetAll()
    {
        return Ok(Resources);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Resource> GetById(int id)
    {
        var resource = Resources.FirstOrDefault(
            resource => resource.Id == id);

        if (resource is null)
        {
            return NotFound();
        }

        return Ok(resource);
    }
}