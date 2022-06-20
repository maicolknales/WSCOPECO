using System.ComponentModel.DataAnnotations;

namespace CopecoWebSite.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identidad { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }
        public string Domicilio { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }

        public virtual string NombreCompleto
        {
            get
            {
                if (Nombre is null) return string.Empty;

                return $"{Nombre} {Apellido} ";
            }
        }
    }
}
