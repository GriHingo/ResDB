using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
        List<string>[] Select();

        Connection CreateConnection();
    }
}
