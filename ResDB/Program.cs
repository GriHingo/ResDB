using HickoryIT.Shared.Utils.Images;
using HickoryIT.Shared.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HickoryIT.Shared.Utils;
using HickoryIT.Core.Application;
using System.Drawing;
using HickoryIT.Shared.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbtype = ConfigurationHandler.GetValue("DB_Type");
            string dbname = ConfigurationHandler.GetValue("DB_Name");
            string dbserver = ConfigurationHandler.GetValue("DB_Server");
            string dbuser = ConfigurationHandler.GetValue("DB_User");
            string dbpassword = ConfigurationHandler.GetValue("DB_Password");

            dbserver = dbserver == null ? "localhost" : dbserver;
            dbuser = dbuser == null ? "root" : dbuser;
            dbpassword = dbpassword == null ? "root" : dbpassword;

            DatabaseManager database_manager = new DatabaseManager(dbtype, dbname, dbserver, dbuser, dbpassword);

            string storage_path = ConfigurationHandler.GetValue("Storage_path");

            ResourceDB res = new ResourceDB(database_manager, storage_path);

            res.Add( new Category(100, "Image", "Resource is a image (Image, Photo etc)") );
            res.Add( new Category(200, "Text", "UTF-8 encoded text") );

            
            //res.AddImageResource(System.Drawing.Image.FromFile("Z:\\Pictures\\IMG_0538.JPG"));

            //IDatabase db = null;

            //string dbtype = ConfigurationHandler.GetValue("DB");

            //switch (dbtype)
            //{
            //    case "MySql":
            //    default:
            //        db = new MySQLDatabase();
            //        break;
            //}

            //db.Insert();
            //db.Select();

            //// z:\pictures\img_0538.jpg

            /*
            Info inf = new Info("Z:\\Pictures\\IMG_0538.JPG");

            foreach (string propertyname in inf.PropertyItems.Keys)
            {
                Debug.WriteLine(propertyname + ": " + (inf.PropertyItems[propertyname]).ToString());
                Console.WriteLine(propertyname + ": " + (inf.PropertyItems[propertyname]).ToString());

            }
             */
        }
    }
}
