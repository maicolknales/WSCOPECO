using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CopecoWebSite.Models;

namespace CopecoWebSite.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly CopecoWebSiteContext _context;

        public NoticiasController(CopecoWebSiteContext context)
        {
            _context = context;
        }

        // GET: Noticias
        public async Task<IActionResult> Index()
        
        {
              return _context.Noticias != null ? 
                          View(await _context.Noticias.ToListAsync()) :
                          Problem("Entity set 'CopecoWebSiteContext.Noticias'  is null.");
        }

        // GET: Noticias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Noticias == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        // GET: Noticias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Noticias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Subtitulo,Descripcion,Cuerpo,Foto")] Noticia noticia)
        {
            if (ModelState.IsValid)
            {

                _context.Add(noticia);
                await _context.SaveChangesAsync();

                byte[] bytesFoto = FileToBytesArray(noticia.Foto);
                string nombreArchivo = noticia.Id.ToString() + "." + noticia.Foto.ContentType.Replace("image/", string.Empty);
                string ruta = "wwwroot/img/Noticias";

                GuardarArchivo(nombreArchivo, ruta, bytesFoto);
                return RedirectToAction(nameof(Index));
            }
            return View(noticia);
        }

        public byte[] FileToBytesArray(IFormFile file)
        {

            if (file.Length == 0) throw new Exception("Archivo vacio");

            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public void GuardarArchivo(string nombreArchivo, string rutaCarpeta, byte[] bytesFoto)
        {
            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            System.IO.File.WriteAllBytes(rutaCompleta, bytesFoto);
        }


        // GET: Noticias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Noticias == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticias.FindAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return View(noticia);
        }

        // POST: Noticias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Subtitulo,Descripcion,Cuerpo,FechaCreacion,FechaModificacion,Activo")] Noticia noticia)
        {
            if (id != noticia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticiaExists(noticia.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(noticia);
        }

        // GET: Noticias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Noticias == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Noticias == null)
            {
                return Problem("Entity set 'CopecoWebSiteContext.Noticias'  is null.");
            }
            var noticia = await _context.Noticias.FindAsync(id);
            if (noticia != null)
            {
                _context.Noticias.Remove(noticia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiaExists(int id)
        {
          return (_context.Noticias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
