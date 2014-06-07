using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Properties
    {
        [DataMember(Name = "resource_id")]
        public int Resource_Id { get; set; }

        [DataMember(Name = "property")]
        public Property Property { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }

}
