using GoalApp.Mobile.ViewModels;
using GoalApp.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GoalApp.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
