using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CopecoWebSite.Models
{
    public class SliderHome
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaSubida { get; set; }

        [DataType(DataType.Date)] 
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }

        [NotMapped]
        public IFormFile Foto { get; set; }

        public string Extension { get; set; }

        public void GuardarArchivo(string nombreArchivo, string rutaCarpeta, byte[] bytesFoto)
        {
            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            File.WriteAllBytes(rutaCompleta, bytesFoto);
        }
    }
}
