﻿using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AstrologyDoc
{
    public partial class App : Application
    {
        public static IList<string> AstrologyDoc { get; set; }

        public App()
        {
            InitializeComponent();
            AstrologyDoc = new List<string>();
            MainPage = new NavigationPage(new MainPage());
        }
        
    }
}