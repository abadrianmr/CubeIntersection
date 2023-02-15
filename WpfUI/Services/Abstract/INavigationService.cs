using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfUI.Services.Abstract
{
    /// <summary>
    /// All navigations should be defined in this interface, this could be a generic implementation but for simplicity I'll keep it like this. 
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Show the <see cref="MainWindow"/>
        /// </summary>
        void ShowMainWindow();
    }
}
