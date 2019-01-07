using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XConcept1.Classes;

namespace XConcept1.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

            Padding = Device.OnPlatform(new Thickness(), 
                                        new Thickness(10), 
                                        new Thickness());

            employeesListView.ItemTemplate = new DataTemplate(typeof(EmployeeCell));
            employeesListView.RowHeight = 70;

            addButton.Clicked += AddButton_Clicked;
            //employeesListView.ItemSelected += EmployeesListView_ItemSelected;
        }

        //private async void EmployeesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    await Navigation.PushAsync(new EditPage((Employee)e.SelectedItem));
        //}

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameEntry.Text))
            {
                await DisplayAlert("Ошибка", "Нужно писать имя", "Принять");
                firstNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(midleNameEntry.Text))
            {
                await DisplayAlert("Ошибка", "Нужно писать очество", "Принять");
                midleNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastNameEntry.Text))
            {
                await DisplayAlert("Ошибка", "Нужно писать фамилия", "Принять");
                lastNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(levelEntry.Text))
            {
                await DisplayAlert("Ошибка", "Нужно писать уровень", "Принять");
                levelEntry.Focus();
                return;
            }

            InsertEmployee();
        }

        private async void InsertEmployee()
        {
            var employee = new Employee
            {
                FirstName = firstNameEntry.Text,
                MidleName = midleNameEntry.Text,
                LastName = lastNameEntry.Text,
                ContractDate = contractDateDatePicker.Date,
                Level = levelEntry.Text,
                Active = activeSwitch.IsToggled
            };

            using (var db = new DataAccess())
            {
                db.Insert(employee);
                employeesListView.ItemsSource = db.GetList<Employee>();
            }

            await DisplayAlert("Спасибо", "Вы успешно записались на курсы!", "Принять");

            firstNameEntry.Text = string.Empty;
            midleNameEntry.Text = string.Empty;
            lastNameEntry.Text = string.Empty;
            levelEntry.Text = string.Empty;
            contractDateDatePicker.Date = DateTime.Now;
            activeSwitch.IsToggled = true;
            

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (var db = new DataAccess())
            {
                employeesListView.ItemsSource = db.GetList<Employee>();
            }
        }
    }
}