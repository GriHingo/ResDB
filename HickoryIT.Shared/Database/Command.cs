using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public abstract class Command
    {
        public abstract List<Dictionary<string, string>> ExecuteReader();
        public abstract int ExecuteNonQuery();
    }
}
