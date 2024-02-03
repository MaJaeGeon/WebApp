using Microsoft.AspNetCore.Mvc;
using webapp.backend.data.entities;

namespace webapp.backend.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private readonly ApplicationDbContext _db;
        public WeatherForecastController(ApplicationDbContext db) {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() => _db.Forecasts.ToList();
    }
}
