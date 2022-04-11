using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
