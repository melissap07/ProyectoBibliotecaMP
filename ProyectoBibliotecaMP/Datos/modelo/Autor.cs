using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaMP.Datos.modelo
{
    public class Autor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Last name { get; set; }
        public string  Nickname { get; set; }
        public int Date { get; set; }
    }
}
