using HickoryIT.Core.Information;
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

namespace HickoryIT.Core.Function
{
    public class AddResource : FunctionBase, IAddResource
    {
        public AddResource(IInformationAdapter information_adapter ) : base(information_adapter)
        {

        }

        public Resource AddUriResource(Uri uri, int typeId = 0)
        {
            throw new NotImplementedException();
        }

        public Resource AddImageResource(Uri imageUri)
        {
            throw new NotImplementedException();
        }

        public Resource AddImageResource(string imageFilename)
        {
            throw new NotImplementedException();
        }

        public Resource AddImageResource(Image image)
        {
            Resource resource = informationAdapter.AddImage(image);

            return resource;
        }

        public Resource AddFileResource(string filename, int typeId = 0)
        {
            throw new NotImplementedException();
        }

        public Resource AddTextResource(string text)
        {
            throw new NotImplementedException();
        }
    }
}
