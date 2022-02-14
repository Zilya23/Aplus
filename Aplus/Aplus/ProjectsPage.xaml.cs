using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplus.Models;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public string[] projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            projects_lv.ItemsSource = App.
            base.OnAppearing();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void projects_lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}