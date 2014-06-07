using HickoryIT.Core.Function;
using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Application
{
    public class ResourceDB : Application , IFunctionAdapter
    {
        private IFunctionAdapter function_adapter = null;
        private DatabaseManager database_manager = null;
        private string storage_path = null; // root path for storage of filebased resources
        private static ResourceDB instance = null;

        public static ResourceDB Instance
        {
            // Test
            get{ return instance; }
        }

        public ResourceDB(DatabaseManager database_manager, string storage_path, IFunctionAdapter function_adapter)
        {
            instance = this;
            ApplicationInitializer(database_manager, storage_path, function_adapter);
        }

        public ResourceDB(DatabaseManager database_manager, string storage_path)
            : this(database_manager, storage_path, new DefaultFunctionAdapter())
        {
        }

        private void ApplicationInitializer(DatabaseManager database_manager, string storage_path, IFunctionAdapter function_adapter)
        {
            this.database_manager = database_manager;
            this.storage_path = storage_path;
            this.function_adapter = function_adapter;
        }

        #region Application specific methods
        public bool CategoryExists(Category category)
        {
            List<Category> categories = function_adapter.GetAllCategories();

            foreach (Category item in categories)
            {
                if (item.Name.Equals(category.Name))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Resource handling
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public Resource AddUriResource(Uri uri, int typeId = 0)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageUri"></param>
        /// <returns></returns>
        public Resource AddImageResource(Uri imageUri)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageFilename"></param>
        /// <returns></returns>
        public Resource AddImageResource(string imageFilename)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Resource AddImageResource(System.Drawing.Image image)
        {
            return function_adapter.AddImageResource(image);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public Resource AddFileResource(string filename, int typeId = 0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Resource AddTextResource(string text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public Resource AddResource(Resource resource)
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetResourcesWithTypeId(int typeId)
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetResourcesWithUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetResourcesWithUserAndTypeId(User user, int typeId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Category handling
        public Category Add(Category category)
        {
            if (!CategoryExists(category))
            {
                Category c = function_adapter.Add(category);
                return c;
            }
            return category;
        }

        public List<Category> GetAllCategories()
        {
            return function_adapter.GetAllCategories();
        }

        public List<Category> GetCategoryById(string id)
        {
            return function_adapter.GetCategoryById(id);
        }

        public List<Category> GetCategoryByName(string name)
        {
            return function_adapter.GetCategoryByName(name);
        }

        public List<Category> GetCategoryByDescription(string description)
        {
            return function_adapter.GetCategoryByDescription(description);
        }
        #endregion


    }
}
