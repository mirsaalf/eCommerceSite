using eCommerceSite.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceSite.Data
{
    public class SkinCareContext : DbContext
    {
        public SkinCareContext(DbContextOptions<SkinCareContext> options) : base(options)
        {

        }

        public DbSet<Skin> Skins { get; set; }
    }
}
