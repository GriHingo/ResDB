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
    public class AddCategory : Information, IAddCategory
    {
        public Category Add(Category category)
        {
            Category c = null;

            c = Transaction<Category, Category>(add, category);
            
            if (c != null)
                allCategories.Add(c);

            return c;
        }

        private Category add(Connection connection, Category category)
        {
            category.Id = connection.InsertCategory(category);
            return category;
        }
    }
}
