using PopulationApi.Models;
using PopulationApi.Repositories;

namespace PopulationApi.Services
{
    public class PopulationService : IPopulationService
    {
        private readonly ICityRepository _cityRepository;

        public PopulationService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public ComputeResult Compute(ComputeArgs args)
        {
            return new ComputeResult()
            {
                CityName = "Test",
                RadiusInKm = 10.0M,
                Population = 200,
                NumberOfCities = 1
            };
        }
    }
}
