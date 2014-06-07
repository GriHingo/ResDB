using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public interface IConnection
    {
        void BeginTransaction();
        void Open();
        void Close();
    }
}
