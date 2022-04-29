using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaHD.Datos.modelo;

namespace ProyectoBibliotecaMP.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
    }
}
