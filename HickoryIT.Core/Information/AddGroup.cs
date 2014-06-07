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
    public class AddGroup : Information, IAddGroup
    {
        public Group Add(Group group)
        {
            Group c = null;

            c = Transaction<Group, Group>(add, group);

            if (c != null)
                allGroups.Add(c);

            return c;
        }

        private Group add(Connection connection, Group group)
        {
            group.Id = connection.InsertGroup(group);
            return group;
        }
    }
}
