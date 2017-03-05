using System.Collections.Generic;

namespace PopulationApi.Models
{
    public class CityEntity
    {
        public int _id { get; set; }
        public IEnumerable<string> alternate_names { get; set; }
        public IEnumerable<decimal> coordinates { get; set; }
        public string name { get; set; }
        public int population { get; set; }
    }
}
