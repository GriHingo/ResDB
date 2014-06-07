using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Information
{
    public interface IAddImageResource
    {
        Resource AddImage(Image image);
    }
}
