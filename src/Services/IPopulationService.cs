using PopulationApi.Models;

namespace PopulationApi.Services
{
    public interface IPopulationService
    {
        ComputeResult Compute(ComputeArgs args);
    }
}