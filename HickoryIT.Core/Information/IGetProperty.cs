using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public interface IGetProperty
    {
        List<Property> GetAllProperties();
        List<Property> GetPropertyById(string id);
        List<Property> GetPropertyByName(string name);
        List<Property> GetPropertyByDescription(string description);
    }
}
