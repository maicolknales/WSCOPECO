using CopecoWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CopecoWebSite.Controllers
{
    public class SliderHomesController : Controller
    {
        private readonly CopecoWebSiteContext _context;

        public SliderHomesController(CopecoWebSiteContext context)
        {
            _context = context;
        }

        // GET: SliderHomes
        public async Task<IActionResult> Index()
        {
            return _context.SliderHome != null ?
                        View(await _context.SliderHome.ToListAsync()) :
                        Problem("Entity set 'CopecoWebSiteContext.SliderHomes'  is null.");
        }

        // GET: SliderHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SliderHome == null)
            {
                return NotFound();
            }

            var noticia = await _context.SliderHome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        // GET: SliderHomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SliderHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,FechaSubida,FechaModificacion,Activo,Foto")] SliderHome slider)
        {
            if (ModelState.IsValid)
            {
                slider.Extension = slider.Foto.ContentType.Replace("image/", string.Empty);
                _context.Add(slider);
                await _context.SaveChangesAsync();

                byte[] bytesFoto = FileToBytesArray(slider.Foto);
                string nombreArchivo = slider.Id.ToString() + "." + slider.Foto.ContentType.Replace("image/", string.Empty);
                string ruta = "wwwroot/img/CarouselSlider";

                GuardarArchivo(nombreArchivo, ruta, bytesFoto);


                
                return RedirectToAction(nameof(Index));
            }
            return View(slider);
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

        // GET: SliderHomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SliderHome == null)
            {
                return NotFound();
            }

            var noticia = await _context.SliderHome.FindAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return View(noticia);
        }

        // POST: SliderHomes/Edit/5
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

        // GET: SliderHomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SliderHome == null)
            {
                return NotFound();
            }

            var noticia = await _context.SliderHome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        // POST: SliderHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SliderHome == null)
            {
                return Problem("Entity set 'CopecoWebSiteContext.SliderHomes'  is null.");
            }
            var noticia = await _context.SliderHome.FindAsync(id);
            if (noticia != null)
            {
                _context.SliderHome.Remove(noticia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiaExists(int id)
        {
            return (_context.SliderHome?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
