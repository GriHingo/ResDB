using System.Runtime.Serialization;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Group : SuperData
    {
        public Group() : base() { }

        public Group(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }
    }

}
