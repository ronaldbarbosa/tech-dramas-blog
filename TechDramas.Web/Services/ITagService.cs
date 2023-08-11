using TechDramas.Web.Models.Domain;

namespace TechDramas.Web.Services
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllTags();
        Task<Tag> GetTagById(Guid id);
        Task<Tag> CreateTag(Tag tag);
        Task UpdateTag(Tag tag);
        Task DeleteTag(Tag tag);
    }
}
