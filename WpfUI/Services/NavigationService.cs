using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfUI.Services.Abstract;

namespace WpfUI.Services
{    
    public class NavigationService : INavigationService
    {
        private readonly ILifetimeScope _container;

        public NavigationService( ILifetimeScope container )
        {
            _container = container;
        }
        public void ShowMainWindow()
        {
            var window = new MainWindow()
            {
                DataContext = _container.Resolve<MainViewModel>()
            };
            window.Show(); 
        }
    }
}
