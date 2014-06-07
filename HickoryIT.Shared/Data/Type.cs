using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Type : SuperData
    {
        [DataMember(Name = "category")]
        public Category Category { get; set; }

        public Type()
        {

        }

        public Type( Category category, string name, string description)
        {
            this.Id = 1;
            this.Category = category;
            this.Name = name;
            this.Description = description;
        }
    }

}
