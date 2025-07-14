using Identity.Api;
using Identity.Application;
using Identity.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services
.AddApplication()
.AddInfrastructure(builder.Configuration)
.AddPresentation();

var app = builder.Build();

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/health", handler: () => Results.Ok("Healthy"));
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<IdentityDbContext>();
    dbContext.Database.Migrate(); // apply migrations if needed
}

app.Run();