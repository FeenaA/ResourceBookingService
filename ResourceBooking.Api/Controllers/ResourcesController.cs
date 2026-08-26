using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResourceBooking.Api.Contracts.Resources;
using ResourceBooking.Api.Data;
using ResourceBooking.Api.Domain.Entities;

namespace ResourceBooking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ResourcesController : ControllerBase
{
    private readonly ResourceBookingDbContext _dbContext;

    public ResourcesController(ResourceBookingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Resource>>> GetAll()
    {
        var resources = await _dbContext.Resources.ToListAsync();

        return Ok(resources);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Resource>> GetById(int id)
    {
        var resource = await _dbContext.Resources.FindAsync(id);

        if (resource is null)
        {
            return NotFound();
        }

        return Ok(resource);
    }

    [HttpPost]
    public async Task<ActionResult<Resource>> Create(
        CreateResourceRequest request)
    {
        var resource = new Resource
        {
            Name = request.Name,
            Type = request.Type,
            Capacity = request.Capacity,
            Description = request.Description
        };

        _dbContext.Resources.Add(resource);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetById),
            new { id = resource.Id },
            resource);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Resource>> Update(
        int id,
        UpdateResourceRequest request)
    {
        var resource = await _dbContext.Resources.FindAsync(id);

        if (resource is null)
        {
            return NotFound();
        }

        resource.Name = request.Name;
        resource.Type = request.Type;
        resource.Capacity = request.Capacity;
        resource.Description = request.Description;
        resource.IsActive = request.IsActive;

        await _dbContext.SaveChangesAsync();

        return Ok(resource);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resource = await _dbContext.Resources.FindAsync(id);

        if (resource is null)
        {
            return NotFound();
        }

        _dbContext.Resources.Remove(resource);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }
}