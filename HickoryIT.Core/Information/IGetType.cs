using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public interface IGetType
    {
        List<HickoryIT.Shared.Data.Type> GetAllTypes();
        List<HickoryIT.Shared.Data.Type> GetTypeById(string id);
        List<HickoryIT.Shared.Data.Type> GetTypeByName(string name);
        List<HickoryIT.Shared.Data.Type> GetTypeByDescription(string description);
    }
}
