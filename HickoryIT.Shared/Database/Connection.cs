using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HickoryIT.Shared.Extentions;

namespace HickoryIT.Shared.Database
{
    public abstract class Connection : IConnection, ITransaction
    {
        protected ITransaction transaction = null;

        public abstract void Open();

        public abstract void Close();

        public abstract void BeginTransaction();

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public abstract Command GetCommand(string query);

        private int Insert(string table, string column, string value)
        {
            int retval = -1;
            string query = "INSERT INTO " + table + " (" + column + @") VALUES ('" + value + @"')";
            try
            {
                Command cmd = GetCommand(query);

                retval = cmd.ExecuteNonQuery();
            }
            catch(Exception e )
            {
                Console.Out.WriteLine(e.Message);
            }

            
            return retval;
        }

        private List<Dictionary<string, string>> SelectFrom(string table, string where = null)
        {
            List<Dictionary<string, string>> list = null;

            string query = "SELECT * FROM " + table + (string.IsNullOrEmpty(where) ? "" : " WHERE " + where);

            try
            {
                Command cmd = GetCommand(query);

                list = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

            return list;
        }

        public List<HickoryIT.Shared.Data.Type> SelectAllFromType()
        {
            List<HickoryIT.Shared.Data.Type> types = new List<HickoryIT.Shared.Data.Type>();
            List<Dictionary<string, string>> list = null;

            list = SelectFrom("Type");

            foreach (var row in list)
            {
                HickoryIT.Shared.Data.Type type = new HickoryIT.Shared.Data.Type();
                type.Id = row["Id"].ToInt();
                type.Name = row["Name"];
                type.Description = row["Description"];
                type.Category = SelectCategory(row["Category_Id"].ToInt());

                types.Add(type);
            }

            return types;
        }

        public Category SelectCategory(int Id)
        {
            Category category = null;
            List<Dictionary<string, string>> list = null;

            list = SelectFrom("Category", @"Id = '" + Id + @"'");

            foreach (var row in list)
            {
                category = new Category();
                category.Id = row["Id"].ToInt();
                category.Name = row["Name"];
                category.Description = row["Description"];

                break;
            }

            return category;
        }

        public List<Category> SelectAllFromCategory()
        {
            List<Category> categories = new List<Category>();
            List<Dictionary<string, string>> list = null;

            list = SelectFrom("Category");

            foreach (var row in list)
            {
                Category category = new Category();
                category.Id = row["Id"].ToInt();
                category.Name = row["Name"];
                category.Description = row["Description"];

                categories.Add(category);
            }

            return categories;
        }

        public int InsertType(HickoryIT.Shared.Data.Type type)
        {
            string values = type.Id + @"', '" + type.Name + @"', '" + type.Description + @"', '" + type.Category.Id;
            return Insert("Type", "Id, Name, Description, Category_Id", values);
        }

        public int InsertCategory(Category category)
        {
            string values = category.Id + @"', '" + category.Name + @"', '" + category.Description;
            return Insert("Category", "Id, Name, Description", values);
        }

        public int InsertProterty(Property property)
        {
            string values = property.Id + @"', '" + property.Name + @"', '" + property.Description;
            return Insert("Property", "Id, Name, Description", values);
        }

        public int InsertProperties(Properties properties)
        {
            string values = properties.Resource_Id + @"', '" + properties.Property.Id + @"', '" + properties.Value;
            return Insert("Properties", "Resource_Id, Property_Id, Value", values);
        }

        public int InsertResource(Resource resource)
        {
            // The tabel Resource has Id as autoincrement
            string values = resource.Name + @"', '" + resource.Type.Id + @"', '" + resource.Description + @"', '" + resource.Value;
            return Insert("Resource", "Name, Type_Id, Description, Value", values);
        }


        public int InsertProperty(Property property)
        {
            string values = property.Id + @"', '" + property.Name + @"', '" + property.Description;
            return Insert("Property", "Id, Name, Description", values);
        }

        public List<Property> SelectAllFromProperty()
        {
            List<Property> properties = new List<Property>();
            List<Dictionary<string, string>> list = null;

            list = SelectFrom("Property");

            foreach (var row in list)
            {
                Property property = new Property();
                property.Id = row["Id"].ToInt();
                property.Name = row["Name"];
                property.Description = row["Description"];

                properties.Add(property);
            }

            return properties;
        }

        public int InsertGroup(Group group)
        {
            string values = group.Name + @"', '" + group.Description;
            return Insert("Group", "Name, Description", values);
        }

        public List<Group> SelectAllFromGroup()
        {
            List<Group> groups = new List<Group>();
            List<Dictionary<string, string>> list = null;

            list = SelectFrom("Group");

            foreach (var row in list)
            {
                Group group = new Group();
                group.Id = row["Id"].ToInt();
                group.Name = row["Name"];
                group.Description = row["Description"];

                groups.Add(group);
            }

            return groups;
        }
    }
}
