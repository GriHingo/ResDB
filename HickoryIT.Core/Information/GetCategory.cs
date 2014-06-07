using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class GetCategory : Information, IGetCategory
    {
        public List<HickoryIT.Shared.Data.Category> GetAllCategories()
        {
            List<Category> resource = Selection<List<Category>>(all);

            return resource;
        }


        private List<Category> all(Connection connection)
        {
            if(allCategories==null)
            {
                // We cache the categories
                allCategories = connection.SelectAllFromCategory();
            }

            return allCategories;
        }

        public List<Category> GetCategoryById(string id)
        {
            throw new NotImplementedException();
        }

        public List<HickoryIT.Shared.Data.Category> GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<HickoryIT.Shared.Data.Category> GetCategoryByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
