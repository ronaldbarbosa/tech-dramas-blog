using Microsoft.AspNetCore.Mvc;
using TechDramas.Web.Models.Domain;
using TechDramas.Web.Models.ViewModels;
using TechDramas.Web.Services;

namespace TechDramas.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly ITagService _tagService;
        public AdminTagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IActionResult> Index()
        {
            var tags = await _tagService.GetAllTags();
            return View(tags);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTagViewModel addTag)
        {
            await _tagService.CreateTag(new Tag() { Name = addTag.Name, DisplayName = addTag.DisplayName }); 
            return RedirectToAction(nameof(Index));
        }
    }
}
