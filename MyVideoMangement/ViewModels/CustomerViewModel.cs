using System.Collections.Generic;
using MyVideoMangement.Models;

namespace MyVideoMangement.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}