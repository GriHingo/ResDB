using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HickoryIT.Shared.Database
{
    public class MySQLConnection : Connection
    {
        MySqlConnection connection = null;

        public MySQLConnection( MySqlConnection connection)
        {
            this.connection = connection;
        }

        public override void BeginTransaction()
        {
            transaction = new MySQLTransaction(connection.BeginTransaction());
        }

        public override void Open()
        {
            connection.Open();
        }

        public override void Close()
        {
            connection.Close();
        }

        public override Command GetCommand(string query)
        {
            return new MySQLCommand( new MySqlCommand( query, connection ) );
        }
    }
}
