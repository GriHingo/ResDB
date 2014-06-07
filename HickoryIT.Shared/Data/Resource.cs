using System.Runtime.Serialization;
using System.Security.Cryptography;
using HickoryIT.Shared.Extentions;

namespace HickoryIT.Shared.Data
{
    [DataContract]
    public class Resource : SuperData
    {
        [DataMember(Name = "type")]
        public Type Type { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        public Resource( Type type, string name, string description, string value)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Value = value;

        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }

}
