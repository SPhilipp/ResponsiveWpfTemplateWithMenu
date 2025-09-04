using ResponsiveWpfTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;

namespace ResponsiveWpfTest.ViewModels
{
    internal class MainWindowVM : Utilities.ViewModelBase
    {

        private object currentView;

        public bool IsBusy { get; set; }
        public object CurrentView { get => currentView; set { currentView = value; OnPropertyChanged(); } }

        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateSettingsCommand { get; }


        public MainWindowVM()
        {
            NavigateHomeCommand = new RelayCommand(async x => await NavigateHomeAsync(), _ => !IsBusy);
            NavigateSettingsCommand = new RelayCommand(async x => await NavigateSettingsAsync(), _ => !IsBusy);

            //Startup Page
            CurrentView = new HomeViewVM();
        }

        private async Task NavigateHomeAsync() => CurrentView = new HomeViewVM();
        private async Task NavigateSettingsAsync() => CurrentView = new SettingsViewVM();
    }
}
