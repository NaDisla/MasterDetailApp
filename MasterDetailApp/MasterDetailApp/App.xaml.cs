﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetailApp.Views;

namespace MasterDetailApp
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new MasterMenuPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
