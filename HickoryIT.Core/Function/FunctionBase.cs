using HickoryIT.Core.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HickoryIT.Core.Function
{
    public abstract class FunctionBase
    {
        protected IInformationAdapter informationAdapter;

        public FunctionBase() { this.informationAdapter = new DefaultInformationAdapter(); }

        public FunctionBase(IInformationAdapter adapter)
        {
            this.informationAdapter = adapter;
        }


    }
}
