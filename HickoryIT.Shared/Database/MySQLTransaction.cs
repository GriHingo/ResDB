using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Database
{
    public class MySQLTransaction : ITransaction
    {
        private MySqlTransaction mySqlTransaction;

        public MySQLTransaction(MySqlTransaction mySqlTransaction)
        {
            // TODO: Complete member initialization
            this.mySqlTransaction = mySqlTransaction;
        }
        
        public void Commit()
        {
            mySqlTransaction.Commit();
        }

        public void Rollback()
        {
            mySqlTransaction.Rollback();
        }

        public ITransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
