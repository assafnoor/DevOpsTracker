using Identity.Domain.Common.Models;
using Identity.Domain.Users;
using Identity.Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;

public sealed class IdentityDbContext : DbContext
{
    private readonly PublishDomainEventsInterceptor? _publishDomainEventsInterceptor;

    public IdentityDbContext(
        DbContextOptions<IdentityDbContext> options,
        PublishDomainEventsInterceptor publishDomainEventsInterceptor
    ) : base(options)
    {
        _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
    }

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (_publishDomainEventsInterceptor is not null)
        {
            optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
        }

        base.OnConfiguring(optionsBuilder);
    }
}