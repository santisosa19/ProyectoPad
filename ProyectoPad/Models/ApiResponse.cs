using Microsoft.AspNetCore.Mvc;

namespace ProyectoPad.Models
{
    public class ApiResponse
    {
        public int Page { get; set; }
        public List<Pelicula> Results { get; set; }
    }

}
