using Microsoft.AspNetCore.Mvc;
using PopulationApi.Models;
using PopulationApi.Repositories;
using PopulationApi.Services;

namespace PouplationApi.Controllers
{
    [Route("api/[controller]")]
    public class PopulationController : Controller
    {
        private readonly ICityRepository _cityRepository;
        private readonly IPopulationService _populationService;

        public PopulationController (ICityRepository cityRepository, IPopulationService populationService) {
            _cityRepository = cityRepository;
            _populationService = populationService;
        }
        
        // GET api/Population
        [HttpGet("{cityName}/{radius}")]
        public string Get(string cityName, decimal radius)
        {
            ComputeArgs args = new ComputeArgs() {
               CityName = cityName,
               RadiusInKm = radius
            };
            
            ComputeResult computeResult = this._populationService.Compute(args);
            return computeResult;
        }
    }
}
