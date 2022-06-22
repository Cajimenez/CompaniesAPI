using System.Collections.Generic;
using System.Linq;

namespace CompaniesAPI.Services
{
    public abstract class ApiServiceBase
    {
        public int GetBestDeal(IEnumerable<int> cartonDimensions)
        {
            return cartonDimensions.Min(x => x);
        }
    }
}
