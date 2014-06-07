using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public abstract class Information
    {
        protected List<Group> allGroups = null;
        protected List<Category> allCategories = null;
        protected List<HickoryIT.Shared.Data.Type> allTypes = null;
        protected List<Property> allProperties = null; //This should NOT be confused with the Properties tabel

        public T Transaction<T>(Func<Connection, T> myfunc)
        {
            T list = default(T);

            Connection connection = DatabaseManager.Instance.RetrieveConnection();
            connection.BeginTransaction();

            try
            {
                list = myfunc(connection);

                connection.Commit();
            }
            catch (Exception e)
            {
                connection.Rollback();
            }
            finally
            {
                DatabaseManager.Instance.ReturnConnection(connection);
            }

            return list;
        }

        public T Transaction<T, P>(Func<Connection, P, T> myfunc, P image)
        {
            T resource = default(T);

            Connection connection = DatabaseManager.Instance.RetrieveConnection();
            connection.BeginTransaction();

            try
            {
                resource = myfunc(connection, image);

                connection.Commit();
            }
            catch (Exception e)
            {
                resource = default(T);
                connection.Rollback();
            }
            finally
            {
                DatabaseManager.Instance.ReturnConnection(connection);
            }

            return resource;
        }

        public T Selection<T>(Func<Connection, T> myfunc)
        {
            T list = default(T);

            Connection connection = DatabaseManager.Instance.RetrieveConnection();

            try
            {
                list = myfunc(connection);
            }
            catch (Exception e)
            {
            }
            finally
            {
                DatabaseManager.Instance.ReturnConnection(connection);
            }

            return list;
        }

        public T Selection<T, P>(Func<Connection, P, T> myfunc, P param)
        {
            T list = default(T);

            Connection connection = DatabaseManager.Instance.RetrieveConnection();
 
            try
            {
                list = myfunc(connection, param);

            }
            catch (Exception e)
            {
            }
            finally
            {
                DatabaseManager.Instance.ReturnConnection(connection);
            }

            return list;
        }
    }
}
