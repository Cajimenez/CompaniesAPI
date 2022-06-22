using Newtonsoft.Json;
using System.Collections.Generic;

namespace CompaniesAPI.Models
{
    public class Api2Request : Request
    {
        [JsonProperty("consignee")]
        public string Consignee
        {
            get { return base.SourceAddress; }
            set { base.SourceAddress = value; }
        }
        [JsonProperty("consignor")]
        public string Consignor
        {
            get { return base.DestinationAddress; }
            set { base.DestinationAddress = value; }
        }
        [JsonProperty("cartons")]
        public IEnumerable<int> Cartons
        {
            get { return base.CartonDimensions; }
            set { base.CartonDimensions = value; }
        }
    }
}
