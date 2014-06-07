using HickoryIT.Core.Function;
using HickoryIT.Core.Information;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HickoryIT.ResDB.Shared
{
    public class UnityHandler : UnityContainer
    {
        UnityHandler() : base()
        {
            ConfigureUnityContainer();
        }

        private void ConfigureUnityContainer()
        {
            // This registers all classes that implements an interface using the default naming convention 
            // (the interface has the same name as the class but with an I added in the beginning)
            // Example: FileSystemUtilities implement IFileSystemUtilities
            // All are registers as types and will be instantiated for every resolve
            // this is also called "register by convention"
            this.RegisterTypes(
               AllClasses.FromLoadedAssemblies(),
               WithMappings.FromMatchingInterface,
               WithName.Default,
               WithLifetime.PerResolve);

            // thanks to the above code we only need to register things that does not follow the convention
            // or things that we want to resolve in special ways, like singletons.

            // singleton, and it must be registered first sicnce everybody else may depend on config information.
            //unityContainer.RegisterInstance<IConfigurationContainer>(configurationContainer);
            // singleton. The logger must be second since everybody can be expected to create logging information.
            //unityContainer.RegisterInstance<ITimecutLogger>(new TimecutLogger());

            // singleton
            //this.RegisterInstance<IFunctionAdapter>(new DefaultFunctionAdapter());

            // singleton
            //this.RegisterInstance<IInformationAdapter>(new DefaultInformationAdapter());
        }
    }
}
