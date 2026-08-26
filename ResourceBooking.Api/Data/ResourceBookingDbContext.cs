using Microsoft.EntityFrameworkCore;
using ResourceBooking.Api.Domain.Entities;

namespace ResourceBooking.Api.Data;

public class ResourceBookingDbContext : DbContext
{
    public ResourceBookingDbContext(DbContextOptions<ResourceBookingDbContext> options)
        : base(options)
    {
    }

    public DbSet<Resource> Resources => Set<Resource>();
}