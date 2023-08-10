using Microsoft.AspNetCore.Mvc;

namespace TechDramas.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
