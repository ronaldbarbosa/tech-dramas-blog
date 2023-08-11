using TechDramas.Web.Models.Domain;
using TechDramas.Web.Repositories;

namespace TechDramas.Web.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<Tag> CreateTag(Tag tag)
        {
            return await _tagRepository.CreateTag(tag);
        }

        public async Task DeleteTag(Tag tag)
        {
            await _tagRepository.DeleteTag(tag);
        }

        public async Task<IEnumerable<Tag>> GetAllTags()
        {
            return await _tagRepository.GetAllTags();
        }

        public async Task<Tag> GetTagById(Guid id)
        {
            return await _tagRepository.GetTagById(id);
        }

        public async Task UpdateTag(Tag tag)
        {
            await _tagRepository.UpdateTag(tag);
        }
    }
}
