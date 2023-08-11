using Microsoft.EntityFrameworkCore;
using TechDramas.Web.Models.Domain;

namespace TechDramas.Web.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly TechDramasDbContext _context;
        public TagRepository(TechDramasDbContext context)
        {
            _context = context;
        }

        public async Task<Tag> CreateTag(Tag tag)
        {
            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
            return tag;
        }

        public async Task DeleteTag(Tag tag)
        {
            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tag>> GetAllTags()
        {
            return await _context.Tags.ToListAsync();
        }

        public async Task<Tag> GetTagById(Guid id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public async Task UpdateTag(Tag tag)
        {
            _context.Tags.Update(tag);
            await _context.SaveChangesAsync();
        }
    }
}
