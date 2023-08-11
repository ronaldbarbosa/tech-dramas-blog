using Microsoft.AspNetCore.Mvc;
using TechDramas.Web.Models.ViewModels;

namespace TechDramas.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagViewModel addTag)
        {
            var name = addTag.Name;
            var displayName = addTag.DisplayName;

            return View("Add");
        }
    }
}
