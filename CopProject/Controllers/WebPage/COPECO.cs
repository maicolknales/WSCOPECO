using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopProject.Controllers.COPECO
{
    public class COPECO : Controller
    {
        // GET: COPECO
        public ActionResult News()
        {
            return View();
        }

        // GET: COPECO/NewsDetails/5
        public ActionResult NewsDetails(int id)
        {
            return View();
        }

        // GET: COPECO
        public ActionResult AboutUs()
        {
            return View();
        }

        // GET: COPECO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: COPECO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: COPECO/Create
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

        // GET: COPECO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: COPECO/Edit/5
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

        // GET: COPECO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: COPECO/Delete/5
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
