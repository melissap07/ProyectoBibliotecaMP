using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaMP.Datos.modelo
{
    public class Estudiante
    {
        [Key]
        public int NumeroID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Facultad { get; set; }
        public int Semester { get; set; }
    }
}
