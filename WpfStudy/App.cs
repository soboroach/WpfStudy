using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfStudy.Support.UI.Units;

namespace WpfStudy
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new DarkWindow();
        }
    }
}
