using Microsoft.EntityFrameworkCore;
using TechDramas.Web.Models.Domain;

namespace TechDramas.Web.Repositories
{
    public class TechDramasDbContext : DbContext
    {
        // Here, the constructor receives the db options from Program.cs and sets it to base's constructor (DbContext)
        public TechDramasDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
