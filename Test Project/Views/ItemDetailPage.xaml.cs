using System.ComponentModel;
using Test_Project.ViewModels;
using Xamarin.Forms;

namespace Test_Project.Views
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