using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Tags
    {
        [DataMember(Name = "resource_id")]
        public int Resource_Id { get; set; }

        [DataMember(Name = "tag")]
        public Tag Tag { get; set; }
    }

}
