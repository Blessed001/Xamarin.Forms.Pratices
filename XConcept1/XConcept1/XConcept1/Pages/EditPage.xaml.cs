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
	public partial class EditPage : ContentPage
	{
        private Employee employee;
		public EditPage ( Employee employee)
		{
			InitializeComponent ();


            this.employee = employee;

            Padding = Device.OnPlatform(new Thickness(),
                                        new Thickness(10),
                                        new Thickness());

            firstNameEntry.Text = employee.FirstName;
            midleNameEntry.Text = employee.MidleName;
            lastNameEntry.Text = employee.LastName;
            contractDateDatePicker.Date = employee.ContractDate;
            levelEntry.Text = employee.Level;
            activeSwitch.IsToggled = employee.Active;

            updateButton.Clicked += UpdateButton_Clicked;
            deleteButton.Clicked += DeleteButton_Clicked;

        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirm", "Are you sure to delete the record?", "Yes", "No");
            if (!response)
            {
                return;
            }

            using (var db = new DataAccess())
            {
                db.Delete(employee);
            }

            await DisplayAlert("Message", "The record was deleted", "Acept");
            await Navigation.PopAsync();

        }

        private async void UpdateButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameEntry.Text))
            {
                await DisplayAlert("Error", "You must enter a first name", "Acept");
                firstNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(midleNameEntry.Text))
            {
                await DisplayAlert("Error", "You must enter a first name", "Acept");
                midleNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastNameEntry.Text))
            {
                await DisplayAlert("Error", "You must enter a last name", "Acept");
                lastNameEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(levelEntry.Text))
            {
                await DisplayAlert("Error", "You must enter a salary", "Acept");
                levelEntry.Focus();
                return;
            }

            employee.FirstName = firstNameEntry.Text;
            employee.MidleName = midleNameEntry.Text;
            employee.LastName = lastNameEntry.Text;
            employee.Level = levelEntry.Text;
            employee.ContractDate = contractDateDatePicker.Date;
            employee.Active = activeSwitch.IsToggled;

            using (var db = new DataAccess())
            {
                db.Update(employee);
            }

            await DisplayAlert("Message", "The record was updated", "Acept");
            await Navigation.PopAsync();

        }
    }
}