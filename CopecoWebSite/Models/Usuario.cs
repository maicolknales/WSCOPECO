using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CopecoWebSite.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Contraseña = $"Copeco{DateTime.Now.Year}";
            FechaCreacion = DateTime.Now;
            FechaModificacion = DateTime.Now;
            Activo = true;
        }

        public int Id { get; set; }
        [Unicode(true)]
        public string UsuarioCorreo { get; set; }
        [DataType(DataType.Password)] 
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }
        public int? RolId { get; set; }
        public Rol Rol { get; set; }

    }
}
