using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test_Project.Models;
using Test_Project.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_Project.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}