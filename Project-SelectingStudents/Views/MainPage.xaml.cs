using Microsoft.Maui.Controls;
using Project_SelectingStudents.ViewModels;
using System;

namespace Project_SelectingStudents.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _vm = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _vm;
        }

        private void OnCreateClassClicked(object sender, EventArgs e)
        {
            string name = NewClassEntry.Text ?? string.Empty;
            _vm.NewClassName = name;
            _vm.CreateClass();
            NewClassEntry.Text = string.Empty;
        }

        private void OnAddStudentClicked(object sender, EventArgs e)
        {
            string name = NewStudentEntry.Text ?? string.Empty;
            _vm.NewStudentName = name;
            _vm.AddStudent();
            NewStudentEntry.Text = string.Empty;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            _vm.SaveStudents();
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            _vm.DeleteSelectedClass();
        }

        private void OnDrawClicked(object sender, EventArgs e)
        {
            _vm.DrawStudent();
        }

        private void OnAssignLuckyClicked(object sender, EventArgs e)
        {
            _vm.AssignLucky();
        }
    }
}
