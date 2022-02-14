using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplus.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert("", $"Вы хотите удалить {project.NameProject}?", "Удалить", "Отмена"))
            {
                App.ProjectDBClass.DeleteProject(project.ID);
                await Navigation.PushAsync(new ProjectsPage());
            }
        }

        private void btn_cancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void btn_edit_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert("", $"Вы хотите изменить {project.NameProject}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.NameProject))
                {
                    App.ProjectDBClass.SaveProject(project);
                }
                await this.Navigation.PopAsync();
            }
        }
    }
}