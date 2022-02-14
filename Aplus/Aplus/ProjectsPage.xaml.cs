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
            projects_lv.ItemsSource = App.ProjectDBClass.GetProject();
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Project project = new Project();
            AddProjectPage projectPage = new AddProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }

        private async void projects_lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project projectSel = (Project)e.SelectedItem;
            ProjectTabbedPage informationProject = new ProjectTabbedPage();
            informationProject.BindingContext = projectSel;
            await Navigation.PushAsync(informationProject);
        }
    }
}