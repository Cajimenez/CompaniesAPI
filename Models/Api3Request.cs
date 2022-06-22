using System.Runtime.Serialization;

namespace CompaniesAPI.Models
{
    [DataContract]
    public class Api3Request
    {
        [DataMember(Order = 1)]
        public string source { get; set; }
        [DataMember(Order = 2)]
        public string destination { get; set; }
        [DataMember(Order = 3)]
        public Package[] packages { get; set; }
    }

    public class Package
    {
        [DataMember]
        public int package;
    }
}
