using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Tag : SuperData
    {
        [DataMember(Name = "group")]
        public Group Group { get; set; }
    }

}
