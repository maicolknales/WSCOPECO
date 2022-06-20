using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CopecoWebSite.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Subtitulo { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        [DataType(DataType.MultilineText)]
        public string Cuerpo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }
        
        [NotMapped]
        public IFormFile Foto { get; set; }
    }
}
