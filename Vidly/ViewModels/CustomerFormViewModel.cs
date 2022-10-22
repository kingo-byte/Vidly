using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}