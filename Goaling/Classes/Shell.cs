using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goaling.Classes
{
    public interface IShell
    {
        void Run();
    }
    public class Shell : IShell
    {
        private MainWindow mainWindow { get; set; }

        public Shell(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Run()
        {
            mainWindow.Show();
        }
    }
}
