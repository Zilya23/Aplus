﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AuthorizationPage();
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