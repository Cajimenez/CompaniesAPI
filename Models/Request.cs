using System.Collections.Generic;

namespace CompaniesAPI.Models
{
    public abstract class Request
    {
        protected string SourceAddress { get; set; }
        protected string DestinationAddress { get; set; }
        protected IEnumerable<int> CartonDimensions  { get; set; }
    }
}
