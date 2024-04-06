using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website_CLB_HTSV.Areas.Identity.Data;

namespace website_CLB_HTSV.Data;

public class website_CLB_HTSVContext : IdentityDbContext<website_CLB_HTSVUser>
{
    public website_CLB_HTSVContext(DbContextOptions<website_CLB_HTSVContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
