using Microsoft.EntityFrameworkCore;
using ProyectoBiblioDOSZ.Data.Modelo;

namespace ProyectoBiblioDOSZ.NewFolder.Modelo
{
    
	public class RepositorioBiblioteca : DbContext
	{
		public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) : base(options);
		{
			
		}
	public DbSet<Libro> Libros { get; set; }
	public DbSet<Prestamo> Prestamos { get; set; }
	public DbSet<Autor> Autores { get; set; }
	public DbSet<Estudiante>? Estudiantes { get; set; }

}
