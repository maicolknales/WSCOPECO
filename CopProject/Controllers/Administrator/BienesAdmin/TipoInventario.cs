using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopProject.Controllers.Administrator.BienesAdmin
{
    public class TipoInventario : Controller
    {
        // GET: TipoInventario
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoInventario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoInventario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoInventario/Create
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

        // GET: TipoInventario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoInventario/Edit/5
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

        // GET: TipoInventario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoInventario/Delete/5
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
