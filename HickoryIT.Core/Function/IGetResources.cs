using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Function
{
    public interface IGetResources
    {
        List<Resource> GetResourcesWithTypeId(int typeId);
        List<Resource> GetResourcesWithUser(User user);
        List<Resource> GetResourcesWithUserAndTypeId(User user, int typeId);
    }
}
