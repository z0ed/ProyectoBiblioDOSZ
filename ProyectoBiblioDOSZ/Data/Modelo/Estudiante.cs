
using System.ComponentModel.DataAnnotations;
namespace ProyectoBiblioDOSZ.NewFolder.Modelo
{
    public class Estudiante
    {
        [Key]
        public int Identificacion { get; set; }

        public string Nombre { get; set; }

        public string Carrera { get; set; }

        public string Sexo { get; set; }

        public int Edad { get; set; }
    }
}
