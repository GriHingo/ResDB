using HickoryIT.Core.Function;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.Core.Application
{
    public abstract class Application
    {
        IUnityContainer unityContainer;

        public Application() { }

        public Application(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        protected T Resolve<T>()
        {
            return unityContainer.Resolve<T>();
        }

    }
}
