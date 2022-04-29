using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaMP.Datos.modelo
{

    public class Libro
    {
        [Key]
        public int Serial { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }

    }
    
}
