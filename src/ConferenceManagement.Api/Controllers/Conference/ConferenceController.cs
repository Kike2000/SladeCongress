using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagement.Api.Controllers.Conference
{
    public class ConferenceController : Controller
    {
        // GET: ConferenceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConferenceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConferenceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConferenceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConferenceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConferenceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConferenceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConferenceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
