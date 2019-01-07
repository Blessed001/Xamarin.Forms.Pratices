using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using XConcept1.Pages;
using XConcept1.Services;

namespace XConcept1.ViewModels
{
    public class MainViewModel
    {
        private NavigationService navigationService;
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public ObservableCollection<AvaliationViewModel> Avaliations { get; set; }

        public MainViewModel()
        {
            navigationService = new NavigationService();
            LoadMenu();
            LoadDAta();
        }

        public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo); } }

        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }

        private void LoadDAta()
        {
            Avaliations = new ObservableCollection<AvaliationViewModel>();

            
            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladya.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });

            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladyd.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });

            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladyb.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });

            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladye.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });

            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladyc.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });

            Avaliations.Add(new AvaliationViewModel
            {
                Img = "ladyf.jpg",
                Title = "Lorem Ipsum",
                DeliveryDate = DateTime.Today,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            });


        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            

            Menu.Add(new MenuItemViewModel
            {
                Icon = "",
                PageName = "",
                Title = "",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_about.png",
                PageName = "AboutPage",
                Title = "О нас",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_method.png",
                PageName = "MethodPage",
                Title = "Методика",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_subscrib.png",
                PageName = "HomePage",
                Title = "Записаться",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_avaliation.png",
                PageName = "AvaliationPage",
                Title = "Отзыв",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_contact.png",
                PageName = "ContactPage",
                Title = "Контакты",
            });


        }



    }
}
