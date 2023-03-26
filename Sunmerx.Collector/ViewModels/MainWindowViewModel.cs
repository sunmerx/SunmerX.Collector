using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace Sunmerx.Collector.ViewModels
{
    internal class MainWindowViewModel:BindableBase
    {
        public MainWindowViewModel()
        {

        }
        #region TreeView ViewModel

        public ObservableCollection<> MyProperty
        {
            get; set;
        }

        #endregion
    }
}
