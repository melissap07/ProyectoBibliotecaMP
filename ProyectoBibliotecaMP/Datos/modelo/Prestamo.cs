using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaMP.Datos.modelo
{
    public class Prestamo
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Date { get; set; }
        public int Quantity { get; set; }
        
    }
}
