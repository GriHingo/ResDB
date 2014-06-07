using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class GetType : Information, IGetType
    {
        public List<HickoryIT.Shared.Data.Type> GetAllTypes()
        {
            List<HickoryIT.Shared.Data.Type> types = Selection<List<HickoryIT.Shared.Data.Type>>(all);

            return types;
        }

        private List<HickoryIT.Shared.Data.Type> all(Connection connection)
        {
            if( allTypes == null )
            {
                allTypes = connection.SelectAllFromType();
            }

            return allTypes;
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeById(string id)
        {
            throw new NotImplementedException();
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
