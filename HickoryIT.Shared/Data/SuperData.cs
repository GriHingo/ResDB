using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public abstract class SuperData
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
