using HickoryIT.Shared.Data;
using HickoryIT.Shared.Database;
using HickoryIT.Shared.Utils.Images;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public class AddImageResource : Information, IAddImageResource
    {
        public Resource AddImage(Image image)
        {
            Resource resource = Transaction<Resource, Image>(addImage, image);

            return resource;
        }

        private Resource addImage(Connection connection, Image image)
        {
            Resource resource = new Resource( new HickoryIT.Shared.Data.Type(null, "",""), "testname", "testdescription", "testvalue");

            // TODO: Add the resource to DB
            connection.InsertResource(resource);

            // Get properties of image and add this/those
            Info inf = new Info(image);

            foreach (string propertyname in inf.PropertyItems.Keys)
            {
                Debug.WriteLine(propertyname + ": " + (inf.PropertyItems[propertyname]).ToString());
                Console.WriteLine(propertyname + ": " + (inf.PropertyItems[propertyname]).ToString());
            }
            // TODO: Save image to disc

            return resource;
        }
    }
}
