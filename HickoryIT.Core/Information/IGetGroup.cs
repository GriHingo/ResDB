using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public interface IGetGroup
    {
        List<Group> GetAllGroups();
        List<Group> GetGroupById(string id);
        List<Group> GetGroupByName(string name);
        List<Group> GetGroupByDescription(string description);
    }
}
