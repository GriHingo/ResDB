using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Function
{
    public class GetCategory : FunctionBase, IGetCategory
    {
        public GetCategory(HickoryIT.Core.Information.IInformationAdapter information_adapter)
            : base(information_adapter)
        {

        }

        public List<Category> GetAllCategories()
        {
            return null;
        }


        public List<Category> GetCategoryById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
