using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HickoryIT.Shared.Data;
using HickoryIT.Core.Information;

namespace HickoryIT.Core.Function
{
    public class GetResources : FunctionBase, IGetResources
    {
        public List<Resource> GetResourcesWithTypeId(int typeID)
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetResourcesWithUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetResourcesWithUserAndTypeId(User user, int typeId)
        {
            throw new NotImplementedException();
        }
    }
}
