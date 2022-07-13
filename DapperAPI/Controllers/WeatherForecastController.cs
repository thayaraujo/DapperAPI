using DapperAPI.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DapperAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ICityRepository _cityRepository;

        public WeatherForecastController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetCities()
        {
            var cities = await _cityRepository.GetCities();
            return Ok(cities);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetCity(int id)
        {
            var city = await _cityRepository.GetCity(id);
            return Ok(city);
        }
    }
}
