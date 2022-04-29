using Microsoft.AspNetCore.Mvc;

namespace ProyectoBiblioDOSZ.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BibliotecaController: ControllerBase

    {
        public string PropiedadBiblioteca { get; set; }
        public BibliotecaController()
        {
            
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "Tienes el libro";
        }
		[HttpPut]

		public string ActualizarLibro()
		{
			return "No tiene permiso";
		}

		[HttpPost]

		public string AgregarLibro()
		{
			return "No tiene permiso";
		}

		[HttpDelete]
		public string BorrarLibro()
		{
			return "No tiene permiso";
		}

		//Prestamo
		[HttpGet]

		public string ObtenerPrestamo()
		{
			return "Estado prestamo:";
		}

		[HttpPut]

		public string ActualizarPrestamo()
		{
			return "No tiene permisos";
		}

		[HttpPost]

		public string AgregarPrestamo()
		{
			return "No tiene permisos";
		}

		[HttpDelete]
		public string BorrarPrestamo()
		{
			return "No tiene permisos";
		}

		//Autor

		[HttpGet]
		public string ObtenerAutor()
		{
			return "Autor:";
		}

		[HttpPut]

		public string ActualizarAutor()
		{
			return "No tiene permisos";
		}

		[HttpPost]

		public string AgregarAutor()
		{
			return "No tiene permisos";
		}

		[HttpDelete]
		public string BorrarAutor()
		{
			return "No tiene permisos";
		}

		//Estudiante

		[HttpGet]
		public string ObtenerEstudiante()
		{
			return "Estudiante:";
		}

		[HttpPut]

		public string ActualizarEstudiante()
		{
			return "No tiene permisos";
		}

		[HttpPost]

		public string AgregarEstudiante()
		{
			return "No tiene permisos";
		}

		[HttpDelete]
		public string BorrarEstudiante()
		{
			return "No tiene permisos";
		}

	}
}
