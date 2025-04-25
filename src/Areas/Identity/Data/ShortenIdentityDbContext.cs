using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shorten.Areas.Identity.Data
{
    public class ShortenIdentityDbContext : IdentityDbContext
    {
        public ShortenIdentityDbContext(DbContextOptions<ShortenIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
