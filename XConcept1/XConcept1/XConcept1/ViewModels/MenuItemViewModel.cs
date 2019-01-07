using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XConcept1.Pages;
using XConcept1.Services;

namespace XConcept1.ViewModels
{
    public class MenuItemViewModel
    {
        private NavigationService navigationService;

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(() => navigationService.Navigate(PageName));
            }
        }
    }
}
