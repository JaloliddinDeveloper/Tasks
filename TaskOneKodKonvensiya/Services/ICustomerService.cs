//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//==================================================

using TaskOneKodKonvensiya.Models.Foundations.Customers;

namespace TaskOneKodKonvensiya.Services
{
    internal interface ICustomerService
    {
        ValueTask<Customer> AddCustomerAsync(Customer customer);
        IQueryable<Customer> RetrieveAllCustomers();
        ValueTask<Customer> RetrieveCustomerAsync(Guid id);
        ValueTask<Customer> ModifyCustomerAsync(Customer customer);
        ValueTask<Customer> RemoveCustomerAsync(Customer customer);
    }
}
