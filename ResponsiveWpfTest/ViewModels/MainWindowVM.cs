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
    public class MainWindowVM : Utilities.ViewModelBase
    {
        public event EventHandler<MainWindowVM> Event_CloseWindow;

        private object currentView;
        private string programTitle;
        private int headerHeight = 80;

        public int HeaderHeight { get => headerHeight; set => headerHeight = value; }
        public string ProgramTitle { get => programTitle; set => programTitle = value; }
        public bool IsBusy { get; set; }
        public object CurrentView { get => currentView; set { currentView = value; OnPropertyChanged(); } }

        public ICommand WindowCloseCommand { get; }
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateSettingsCommand { get; }


        public MainWindowVM()
        {
            WindowCloseCommand = new RelayCommand(async x => await WindowCloseAsync(), _ => !IsBusy);
            NavigateHomeCommand = new RelayCommand(async x => await NavigateHomeAsync(), _ => !IsBusy);
            NavigateSettingsCommand = new RelayCommand(async x => await NavigateSettingsAsync(), _ => !IsBusy);

            //Startup Page
            CurrentView = new HomeViewVM();
        }

        private async Task WindowCloseAsync()
        {
            Event_CloseWindow.BeginInvoke(this, this, null, null);
        }

        private async Task NavigateHomeAsync() => CurrentView = new HomeViewVM();
        private async Task NavigateSettingsAsync() => CurrentView = new SettingsViewVM();
    }
}
