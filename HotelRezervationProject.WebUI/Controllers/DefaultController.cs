using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers // Projenizin namespace'ini buraya yazın
{
    public class DefaultController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }
    }
}