using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NetCoreIdentity.Web.Models
{
	public class AppDbContext:IdentityDbContext<AppUser,AppRole,string>
	{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
    }
}
