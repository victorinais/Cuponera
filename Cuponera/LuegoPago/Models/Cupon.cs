using Microsoft.EntityFrameworkCore;

namespace LuegoPago.Models
{
    public class Cupon
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public Double ValorDescuneto { get; set; }
        public int Usabilidad { get; set; }
        public Boolean Estado { get; set; }

    }
}