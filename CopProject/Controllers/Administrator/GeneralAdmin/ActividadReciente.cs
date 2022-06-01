using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopProject.Controllers.Administrator.GeneralAdmin
{
    public class ActividadReciente : Controller
    {
        // GET: ActividadReciente
        public ActionResult Index()
        {
            return View();
        }

        // GET: ActividadReciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActividadReciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActividadReciente/Create
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

        // GET: ActividadReciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActividadReciente/Edit/5
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

        // GET: ActividadReciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActividadReciente/Delete/5
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
