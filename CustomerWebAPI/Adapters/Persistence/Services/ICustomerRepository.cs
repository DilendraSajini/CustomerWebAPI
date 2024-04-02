﻿using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Adapters.Persistence.Services
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public Customer GetCustomerById(int id);
        public int CreateCustomer(Customer customer);
        public int DeleteCustomerById(int customerId);

    }
}