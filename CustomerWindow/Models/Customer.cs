using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWindow.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string TransactionNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
    }
}
