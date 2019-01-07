using System;
using System.Collections.Generic;
using System.Text;
using XConcept1.ViewModels;

namespace XConcept1.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

    }
}
