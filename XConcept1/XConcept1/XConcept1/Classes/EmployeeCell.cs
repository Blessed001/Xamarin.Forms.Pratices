using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XConcept1.Classes
{
    public class EmployeeCell : ViewCell
    {
        public EmployeeCell()
        {
            var employeeIdLabel = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
            };

            employeeIdLabel.SetBinding(Label.TextProperty, new Binding("EmployeeId"));

            var fullNameLabel = new Label
            {
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            fullNameLabel.SetBinding(Label.TextProperty, new Binding("FullName"));

            var contractDateLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            contractDateLabel.SetBinding(Label.TextProperty, new Binding("ContractDate", stringFormat: "{0:yyyy/MM/dd}"));

            var levelLabel = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            levelLabel.SetBinding(Label.TextProperty, new Binding("Level"));

            var activeSwitch = new Switch
            {
                IsEnabled = false,
                HorizontalOptions = LayoutOptions.End
            };

            activeSwitch.SetBinding(Switch.IsToggledProperty, new Binding("Active"));

            var line1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                     fullNameLabel
                },
            };

            var line2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    contractDateLabel, levelLabel, activeSwitch,
                },
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    line1, line2,
                },
            };

        }
    }
}
