using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Category : SuperData
    {
        public Category() : base() { }

        public Category(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }
    }

}
