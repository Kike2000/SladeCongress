using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagement.Api.Controllers.Area
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
