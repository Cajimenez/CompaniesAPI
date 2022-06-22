using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CompaniesAPI.Models
{
    public class Api1Request : Request
    {
        [JsonProperty("contact address")]
        public string ContactAddress 
        { 
            get { return base.SourceAddress; }
            set { base.SourceAddress = value; } 
        }
        [JsonProperty("warehouse address")]
        public string WarehouseAddress 
        {
            get { return base.DestinationAddress; }
            set { base.DestinationAddress = value; }
        }
        [JsonProperty("package dimensions")]
        public IEnumerable<int> PackageDimensions 
        {
            get { return base.CartonDimensions; }
            set { base.CartonDimensions = value; }
        }
    }
}
