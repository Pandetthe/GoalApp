using GoalApp.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GoalApp.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}