using System;
using System.Collections.Generic;
using PopulationApi.Models;
using System.Linq;

namespace PopulationApi.Repositories
{
    public class CityRepository : ICityRepository
    {
        readonly Dictionary<int, CityEntity> _cities = new Dictionary<int, CityEntity>();

        public CityRepository()
        {
            _cities.Add(1, new CityEntity() { _id = 1, alternate_names = new List<string> () { "name" }, name = "City Name", population = 200 });
        }

        public CityEntity Add(IMongoContext mongoContext, CityEntity cityToAdd)
        {
            _cities.Add(new Random().Next(2), cityToAdd);
            return cityToAdd;
        }

        public CityEntity FindCityByName(IMongoContext mongoContext, string name)
        {
            return _cities.First(c => c.Value.name == name).Value;
        }

        public IEnumerable<CityEntity> FindNearestCities(IMongoContext mongoContext, IEnumerable<decimal> coordinates, decimal radiusInKm)
        {
            return _cities.Select(d => d.Value);
        }
    }
}
