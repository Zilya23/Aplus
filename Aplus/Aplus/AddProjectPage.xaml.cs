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
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private async void btn_add_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (!String.IsNullOrEmpty(project.NameProject))
            {
                App.ProjectDBClass.SaveProject(project);
            }
            await this.Navigation.PopAsync();
        }

        private void btn_cancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}