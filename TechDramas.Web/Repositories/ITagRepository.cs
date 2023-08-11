using TechDramas.Web.Models.Domain;

namespace TechDramas.Web.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllTags();
        Task<Tag> GetTagById(Guid id);
        Task<Tag> CreateTag(Tag tag);
        Task UpdateTag(Tag tag);
        Task DeleteTag(Tag tag);
    }
}
