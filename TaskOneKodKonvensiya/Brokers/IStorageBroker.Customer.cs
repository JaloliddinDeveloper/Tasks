//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//==================================================

using TaskOneKodKonvensiya.Models.Foundations.Customers;

namespace TaskOneKodKonvensiya.Brokers
{
    public interface IStorageBroker
    {
        ValueTask<Customer> InsertCustomerAsync(Customer customer);
        IQueryable<Customer> SelectAllCustomers();
        ValueTask<Customer> SelectCustomerAsync(Guid id);
        ValueTask<Customer> UpdateCustomerAsync(Customer customer);
        ValueTask<Customer> DeleteCustomerAsync(Customer customer);  
    }
}
