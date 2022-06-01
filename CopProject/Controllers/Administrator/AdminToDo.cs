using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopProject.Controllers.Administrator
{
    public class AdminToDo : Controller
    {
        // GET: AdminToDo
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminToDo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminToDo/Create
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

        // GET: AdminToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminToDo/Edit/5
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

        // GET: AdminToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminToDo/Delete/5
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
