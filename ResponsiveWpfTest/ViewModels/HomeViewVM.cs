using ResponsiveWpfTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveWpfTest.ViewModels
{
    public class HomeViewVM : ViewModelBase
    {
        private string title = "Startseite";

        public string Title { get => title; set { title = value; OnPropertyChanged(); } }
    }
}
