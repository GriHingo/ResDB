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
    public class AddType : Information, IAddType
    {
        public HickoryIT.Shared.Data.Type Add(HickoryIT.Shared.Data.Type type)
        {
            HickoryIT.Shared.Data.Type t = Transaction<HickoryIT.Shared.Data.Type, HickoryIT.Shared.Data.Type>(add, type);

            if (t != null)
                allTypes.Add(t);

            return t;
        }

        private HickoryIT.Shared.Data.Type add(Connection connection, HickoryIT.Shared.Data.Type type)
        {
            type.Id = connection.InsertType(type);

            return type;
        }
    }
}
