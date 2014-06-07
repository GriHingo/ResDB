using HickoryIT.Core.Shared;
using HickoryIT.Shared.Data;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Function
{
    public class DefaultFunctionAdapter : Adapter,
        IFunctionAdapter
    {
        private HickoryIT.Core.Information.IInformationAdapter information_adapter;

        private AddResource addResource = null;
        private GetResources getResources = null;
        private AddCategory addCategory = null;
        private GetCategory getCategory = null;

        public DefaultFunctionAdapter() : this( new HickoryIT.Core.Information.DefaultInformationAdapter())
        {
        }
        public DefaultFunctionAdapter(HickoryIT.Core.Information.IInformationAdapter information_adapter)
        {
            this.information_adapter = information_adapter;
        }
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

        private AddResource AddResource()
        {
            if (addResource == null)
            {
                addResource = new AddResource(information_adapter);
            }
            return addResource;
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
            return AddResource().AddImageResource(image);
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

        private AddCategory AddCategory()
        {
            if (addCategory == null)
            {
                addCategory = new AddCategory(information_adapter);
            }
            return addCategory;
        }

        private GetCategory GetCategory()
        {
            if (getCategory == null)
            {
                getCategory = new GetCategory(information_adapter);
            }
            return getCategory;
        }

        public Category Add(Category category)
        {
            return AddCategory().Add(category);
        }

        public List<Category> GetAllCategories()
        {
            return GetCategory().GetAllCategories();
        }

        public List<Category> GetCategoryById(string name)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByDescription(string name)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
