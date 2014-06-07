using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class GetGroup : Information, IGetGroup
    {
        public List<Group> GetAllGroups()
        {
            List<Group> group = Selection<List<Group>>(all);

            return group;
        }


        private List<Group> all(Connection connection)
        {
            if (allGroups == null)
            {
                // We cache the categories
                allGroups = connection.SelectAllFromGroup();
            }

            return allGroups;
        }

        public List<Group> GetGroupById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetGroupByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetGroupByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
