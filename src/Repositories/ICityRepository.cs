using System.Collections.Generic;
using PopulationApi.Models;

namespace PopulationApi.Repositories
{
    public interface ICityRepository
    {
        CityEntity FindCityByName(IMongoContext mongoContext, string name);

        IEnumerable<CityEntity> FindNearestCities(IMongoContext mongoContext, IEnumerable<decimal> coordinates, decimal radiusInKm);

        CityEntity Add(IMongoContext mongoContext, CityEntity cityToAdd);
    }
}
