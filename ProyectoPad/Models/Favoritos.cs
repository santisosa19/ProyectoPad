using Microsoft.AspNetCore.Mvc;

namespace ProyectoPad.Models
{
    public class Favorito
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string poster_path { get; set; }
    }

}
