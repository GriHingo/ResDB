using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Function
{
    public class AddCategory : FunctionBase, IAddCategory
    {
        public AddCategory(HickoryIT.Core.Information.IInformationAdapter information_adapter)
            : base(information_adapter)
        {

        }

        public Category Add(Category category)
        {
            return informationAdapter.Add(category);
        }
    }
}
