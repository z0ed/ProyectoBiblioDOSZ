using System.ComponentModel.DataAnnotations;
namespace ProyectoBiblioDOSZ.Data.Modelo
{
    public class Autor
    {
        [Key]
        public int AutID { get; set; }

        public string Nombre { get; set; }
    }
}
