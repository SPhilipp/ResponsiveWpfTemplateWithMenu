﻿using ResponsiveWpfTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveWpfTest.ViewModels
{
    public class SettingsViewVM : ViewModelBase
    {
        private string title = "Einstellungen";

        public string Title { get => title; set { title = value; OnPropertyChanged(); } }
    }
}
