using System;
using System.Collections.Generic;
using System.Text;
using XConcept1.Pages;

namespace XConcept1.Services
{
    public class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "AboutPage":
                    await App.Navigator.PushAsync(new AboutPage());
                    break;
                case "MethodPage":
                    await App.Navigator.PushAsync(new MethodPage());
                    break;
                case "HomePage":
                    await App.Navigator.PushAsync(new HomePage());
                    break;
                case "AvaliationPage":
                    await App.Navigator.PushAsync(new AvaliationPage());
                    break;
                case "ContactPage":
                    await App.Navigator.PushAsync(new ContactPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                case "NewAvaliationPage":
                    await App.Navigator.PushAsync(new NewAvaliationPage());
                    break;
                default:
                    break;
            }
        }
    }
}
