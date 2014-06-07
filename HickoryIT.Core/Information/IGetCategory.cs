using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public interface IGetCategory
    {
        List<Category> GetAllCategories();
        List<Category> GetCategoryById(string id);
        List<Category> GetCategoryByName(string name);
        List<Category> GetCategoryByDescription(string description);
    }
}
