using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using HickoryIT.Shared.Utils.Images;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class AddProperty : Information, IAddProperty
    {
        public Property Add(Property property)
        {
            Property resource = Transaction<Property, Property>(add, property);

            if (resource != null)
                allProperties.Add(resource);

            return resource;
        }

        private Property add(Connection connection, Property property)
        {
            property.Id = connection.InsertProperty(property);

            return property;
        }
    }
}
