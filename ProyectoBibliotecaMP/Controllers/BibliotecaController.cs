
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaMP.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController:ControllerBase
    {
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "Has obtenido el libro correctamente";
        }
        public string ObtenerEstudiante()
        {
            return "Has obtenido el estudiante";
        }
        public string ObtenerAutor()
        {
            return "Este es el Autor";
        }
        public string ObtenerPrestamo()
        {
            return "El préstamo fue obtenido correctamente";
        }
        [HttpPost]
        public string AgregarLibro()
        {
            return "Se ha agregado el libro";
        }
        public string AgregarEstudiante()
        {
            return "El estudiante fue añadido correctamente";
        }
        public string AgregarAutor()
        {
            return "Ya tienes el Autor";
        }
        public string AgregarPrestamo()
        {
            return "El prestamo fue añadido correctamente";
        }
        [HttpPut]
        public string ActualizarLibro()
        {
            return "Ya tienes este libro";
        }
        public string ActualizarEstudiante()
        {
            return "Estudiante ha sido actualizado";
        }
        public string ActualizarAutor()
        {
            return "Ya actualizaste el Autor";
        }
        public string ActualizarPrestamo()
        {
            return "Prestamo ha sido actualizado";
        }
        [HttpDelete]
        public string EliminarLibro()
        { 
            return "Ya eliminaste este libro";
        }
        public string EliminarEstudiante()
        {
            return "El estudiante fue eliminado correctamente";
        }
        public string EliminarAutor()
        {
            return "Ya eliminaste este Autor";
        }
        public string EliminarPrestamo()
        {
            return "El prestamo fue eliminado correctamente";
        }
    }
}
