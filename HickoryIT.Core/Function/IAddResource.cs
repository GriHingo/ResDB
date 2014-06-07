using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HickoryIT.Core.Function
{
    public interface IAddResource
    {
        Resource AddUriResource(Uri uri, int typeId = 0);
        Resource AddImageResource(Uri imageUri);
        Resource AddImageResource(string imageFilename);
        Resource AddImageResource(Image image);
        Resource AddFileResource(string filename, int typeId = 0);
        Resource AddTextResource(string text);
    }
}
