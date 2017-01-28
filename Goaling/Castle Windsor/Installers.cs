using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Goaling.Classes;
using Goaling.DAL;
using Goaling.DAL.Repository;

namespace Goaling.Castle_Windsor
{
    public class Installers : IWindsorInstaller
    {
        public void Install(IWindsorContainer windsorContainer, IConfigurationStore configurationStore)
        {
            windsorContainer.Register(Component.For<IBowlerRepository>().ImplementedBy<BowlerRepository>().LifestyleTransient())
                .Register(Component.For<IShell>().ImplementedBy<Shell>().LifestyleTransient())
                .Register(Component.For<GoalingEntities>().LifestyleSingleton())
                .Register(Component.For<MainWindow>().LifestyleTransient());
        }
    }
}
