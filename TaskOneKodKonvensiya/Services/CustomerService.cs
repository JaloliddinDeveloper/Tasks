//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//==================================================

using TaskOneKodKonvensiya.Brokers;
using TaskOneKodKonvensiya.Models.Foundations.Customers;

namespace TaskOneKodKonvensiya.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IStorageBroker storageBroker;

        public CustomerService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }
        public async ValueTask<Customer> AddCustomerAsync(Customer customer)
        {
            return await this.storageBroker.InsertCustomerAsync(customer);
        }
        public IQueryable<Customer> RetrieveAllCustomers()
        {
           return this.storageBroker.SelectAllCustomers();
        }
        public  async ValueTask<Customer> RetrieveCustomerAsync(Guid id)
        {
            return await this.storageBroker.SelectCustomerAsync(id);
        }

        public async ValueTask<Customer> ModifyCustomerAsync(Customer customer)
        {
           return await storageBroker.UpdateCustomerAsync(customer);
        }

        public async ValueTask<Customer> RemoveCustomerAsync(Customer customer)
        {
            return await storageBroker.DeleteCustomerAsync(customer);
        }
    }
}
