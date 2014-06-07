using HickoryIT.Core.Shared;
using HickoryIT.Shared.Data;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class DefaultInformationAdapter : IInformationAdapter
    {
        private AddImageResource addImageResource = null;
        private AddCategory addCategory = null;
        private GetCategory getCategory = null;
        private AddType addType = null;
        private GetType getType = null;
        private AddProperty addProperty = null;
        private GetProperty getProperty = null;
        private AddGroup addGroup = null;
        private GetGroup getGroup = null;

        ResourceHandler resourceHandler = new ResourceHandler();

        public DefaultInformationAdapter()
        {
        }
        #region Resource Handling
        public Resource AddText(string text)
        {
            return resourceHandler.AddText(text);
        }

        public Resource AddImage(Image image)
        {
            if (addImageResource==null)
            {
                addImageResource = new AddImageResource();
            }

            return addImageResource.AddImage(image);
        }
        #endregion
        #region Category handling
        private AddCategory AddCategory()
        {
            if (addCategory == null)
            {
                addCategory = new AddCategory();
            }
            return addCategory;
        }
        private GetCategory GetCategory()
        {
            if (getCategory == null)
            {
                getCategory = new GetCategory();
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

        public List<Category> GetCategoryById(string id)
        {
            return GetCategory().GetCategoryById(id);
        }

        public List<Category> GetCategoryByName(string name)
        {
            return GetCategory().GetCategoryByName(name);
        }

        public List<Category> GetCategoryByDescription(string description)
        {
            return GetCategory().GetCategoryByDescription(description);
        }
        #endregion

        #region Type handling
        private AddType AddType()
        {
            if (addType == null)
            {
                addType = new AddType();
            }

            return addType;
        }
        private GetType GetMyType()
        {
            if (getType == null)
            {
                getType = new GetType();
            }
            return getType;
        }

        public HickoryIT.Shared.Data.Type Add(HickoryIT.Shared.Data.Type type)
        {
            return AddType().Add(type);
        }


        public List<HickoryIT.Shared.Data.Type> GetAllTypes()
        {
            return GetMyType().GetAllTypes();
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeById(string id)
        {
            return GetMyType().GetTypeById(id);
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeByName(string name)
        {
            return GetMyType().GetTypeByName(name);
        }

        public List<HickoryIT.Shared.Data.Type> GetTypeByDescription(string description)
        {
            return GetMyType().GetTypeByDescription(description);
        }

        #endregion

        #region Property handling
        private AddProperty AddProperty()
        {
            if (addProperty == null)
            {
                addProperty = new AddProperty();
            }

            return addProperty;
        }
        private GetProperty GetProperty()
        {
            if (getProperty == null)
            {
                getProperty = new GetProperty();
            }
            return getProperty;
        }

        public Property Add(Property property)
        {
            return AddProperty().Add(property);
        }

        public List<Property> GetAllProperties()
        {
            return GetProperty().GetAllProperties();
        }

        public List<Property> GetPropertyById(string id)
        {
            return GetProperty().GetPropertyById(id);
        }

        public List<Property> GetPropertyByName(string name)
        {
            return GetProperty().GetPropertyByName(name);
        }

        public List<Property> GetPropertyByDescription(string description)
        {
            return GetProperty().GetPropertyByDescription(description);
        }
        #endregion
        #region Group handling
        private AddGroup AddGroup()
        {
            if (addGroup == null)
            {
                addGroup = new AddGroup();
            }

            return addGroup;
        }
        private GetGroup GetGroup()
        {
            if (getGroup == null)
            {
                getGroup = new GetGroup();
            }
            return getGroup;
        }

        public Group Add(Group group)
        {
            return AddGroup().Add(group);
        }

        public List<Group> GetAllGroups()
        {
            return GetGroup().GetAllGroups();
        }

        public List<Group> GetGroupById(string id)
        {
            return GetGroup().GetGroupById(id);
        }

        public List<Group> GetGroupByName(string name)
        {
            return GetGroup().GetGroupByName(name);
        }

        public List<Group> GetGroupByDescription(string description)
        {
            return GetGroup().GetGroupByDescription(description);
        }
        #endregion
    }
}
