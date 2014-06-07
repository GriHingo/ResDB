using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public class MySQLCommand : Command
    {
        private MySqlCommand mySqlCommand;

        public MySQLCommand(MySqlCommand mySqlCommand)
        {
            // TODO: Complete member initialization
            this.mySqlCommand = mySqlCommand;
        }

        public override List<Dictionary<string,string>> ExecuteReader()
        {
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            while (reader.Read())
            {
                Dictionary<string, string> row = new Dictionary<string, string>();

                for( int i = 0; i < reader.FieldCount; i++ )
                {
                    row.Add(reader.GetName(i), reader.GetString(i));
                }
                result.Add(row);
            }

            return result;
        }

        public override int ExecuteNonQuery()
        {
            return mySqlCommand.ExecuteNonQuery();
        }
    }
}
