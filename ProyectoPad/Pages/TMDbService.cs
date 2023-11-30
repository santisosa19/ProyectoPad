using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoPad.Pages
{
    public class TMDbService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "d63dbc755c0f7b1e041d82deddcec9dd"; // Reemplaza con tu clave

        public TMDbService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetPeliculasAsync()
        {
            string url = $"movie/popular?api_key={ApiKey}&language=es"; // Ejemplo: Obtener películas populares en español
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                // Manejo de error: response.StatusCode, response.ReasonPhrase, etc.
                return null;
            }
        }
        public async Task<string> BuscarPeliculasAsync(string query = "")
        {
            string url = $"search/movie?api_key={ApiKey}&language=es&query={WebUtility.UrlEncode(query)}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                // Manejo de error: response.StatusCode, response.ReasonPhrase, etc.
                return null;
            }
        }


        public async Task<string> GetPeliculaDetailsAsync(string peliculaId)
        {
            string url = $"movie/{peliculaId}?api_key={ApiKey}&language=es"; // Ejemplo: Obtener detalles de una película por su ID en español
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                // Manejo de error: response.StatusCode, response.ReasonPhrase, etc.
                return null;
            }
        }

    }
}
