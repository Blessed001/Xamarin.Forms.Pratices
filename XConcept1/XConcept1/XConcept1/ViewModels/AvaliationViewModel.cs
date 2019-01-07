using System;
using System.Collections.Generic;
using System.Text;

namespace XConcept1.ViewModels
{
    public class AvaliationViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string Img { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string DeliveryInformation { get; set; }

        public string Client { get; set; }

    }
}
