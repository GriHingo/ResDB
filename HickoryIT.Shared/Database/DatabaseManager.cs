using HickoryIT.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public class DatabaseManager
    {
        private string dbtype;
        private string dbname;
        private string dbserver;
        private string dbuser;
        private string dbpassword;

        private Queue<Connection> connections = new Queue<Connection>();

        private static DatabaseManager instance = null;

        private IDatabase database = null;

        public DatabaseManager(string dbtype, string dbname, string dbserver, string dbuser, string dbpassword)
        {
            // TODO: Complete member initialization
            this.dbtype = dbtype;
            this.dbname = dbname;
            this.dbserver = dbserver;
            this.dbuser = dbuser;
            this.dbpassword = dbpassword;

            Initialize();

            instance = this;
        }

        private void Initialize()
        {
            IDatabase db = null;

            dbserver = dbserver == null ? "localhost" : dbserver;
            dbuser = dbuser == null ? "root" : dbuser;
            dbserver = dbserver == null ? "localhost" : dbserver;

            switch (dbtype.ToUpper())
            {
                case "MYSQL":
                default:
                    db = new MySQLDatabase(dbname, dbserver, dbuser, dbpassword);
                    break;
            }

            database = db;

            // Create pool of connections
            for (int i = 0; i < 10; i++)
            {
                connections.Enqueue(db.CreateConnection());
            }
        }

        public static DatabaseManager Instance { get { return instance; }}

        public IDatabase Database { get { return database; } }


        public Connection RetrieveConnection()
        {
            Connection connection=null;

            lock (connections)
            {
                while (connections.Count < 1)
                {
                    Monitor.Wait(connections);
                }
                connection = connections.Dequeue();
            }

            connection.Open();

            return connection;
        }

        public void ReturnConnection(Connection connection)
        {
            connection.Close();

            lock (connections)
            {
                connections.Enqueue(connection);
                Monitor.Pulse(connections);
            }

        }
    }
}
