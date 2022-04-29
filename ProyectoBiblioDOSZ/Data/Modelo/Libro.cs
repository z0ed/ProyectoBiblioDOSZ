using System.ComponentModel.DataAnnotations;
namespace ProyectoBiblioDOSZ.NewFolder.Modelo
{
    public class Libro
    {
		[Key]
		public int ID { get; set; }

		public string Nombre { get; set; }

		public string Genre { get; set; }

		public string Autor { get; set; }

		public int PgNum { get; set; }




	}
}
