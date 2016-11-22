using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPreviewer.ViewModels;
using Xamarin.Forms;

namespace TestPreviewer
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Init();
            this.BindingContext = vm;
        }
    }
}