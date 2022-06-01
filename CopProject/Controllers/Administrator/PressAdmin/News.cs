using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopProject.Controllers.Administrator.PressAdmin
{
    public class News : Controller
    {
        // GET: AdminNews
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminNews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminNews/Create
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

        // GET: AdminNews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminNews/Edit/5
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

        // GET: AdminNews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminNews/Delete/5
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
