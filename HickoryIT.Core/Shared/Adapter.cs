using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Shared
{
    public abstract class Adapter
    {
        private UnityContainer unityContainer;
        private static Adapter adapter = null;

        public Adapter()
        {
        }

        public Adapter(UnityContainer unityContainer)
        {
            // TODO: Complete member initialization
            this.unityContainer = unityContainer;
        }

    }
}
