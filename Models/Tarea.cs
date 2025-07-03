namespace PruebaApi.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Detalles { get; set; }   
        public DateTime FechaEntrega { get; set; }
        public bool EstadoT { get; set; }
        public required string Prioridad { get; set; }
    }
}
