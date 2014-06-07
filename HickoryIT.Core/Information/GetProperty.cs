using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class GetProperty : Information, IGetProperty
    {
        public List<Property> GetAllProperties()
        {
            List<Property> property = Selection<List<Property>>(all);

            return property;
        }


        private List<Property> all(Connection connection)
        {
            if (allProperties == null)
            {
                // We cache the categories
                allProperties = connection.SelectAllFromProperty();
            }

            return allProperties;
        }

        public List<Property> GetPropertyById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Property> GetPropertyByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Property> GetPropertyByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
