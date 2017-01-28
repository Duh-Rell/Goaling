using System.Windows;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Goaling.Classes;

namespace Goaling
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IWindsorContainer container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            container = new WindsorContainer();
            container.Install(FromAssembly.This());

            var shell = container.Resolve<IShell>();
            shell.Run();
            container.Release(shell);
        }
    }
}
