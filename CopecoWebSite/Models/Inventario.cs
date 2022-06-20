using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CopecoWebSite.Models
{
    public class Inventario
    {
        public Inventario()
        {
            FechaCreacion = DateTime.Now;
            FechaModificacion = DateTime.Now;
            Activo = true;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        [DataType(DataType.Currency)]
        public double Valor { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaAdquisicion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }
    }
}
