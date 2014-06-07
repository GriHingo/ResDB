using HickoryIT.Core.Shared;
using HickoryIT.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HickoryIT.Core.Information
{
    public interface IInformationAdapter : 
        IAddCategory, IGetCategory, 
        IAddType, IGetType, 
        IAddProperty, IGetProperty, 
        IAddGroup, IGetGroup,
        IAddImageResource //: IAddImageResource, IAddCategory, IGetCategory
    {
    }
}
