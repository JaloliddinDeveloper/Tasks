//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//==================================================

using Microsoft.EntityFrameworkCore;
using TaskOneKodKonvensiya.Models.Foundations.Customers;

namespace TaskOneKodKonvensiya.Brokers
{
    public partial class StorageBroker:IStorageBroker
    {
       public DbSet<Customer> Customers { get; set; }
        public async ValueTask<Customer> InsertCustomerAsync(Customer customer)
        {
            return await InsertAsync(customer);
        }
        public  IQueryable<Customer> SelectAllCustomers()
        {
            return SelectAll<Customer>();   
        }
        public async ValueTask<Customer> SelectCustomerAsync(Guid id)
        {
            return await SelectAsync<Customer>(id);
        }
        public async ValueTask<Customer> UpdateCustomerAsync(Customer customer)
        {
            return await UpdateAsync(customer); 
        }
        public ValueTask<Customer> DeleteCustomerAsync(Customer customer)
        {
            return DeleteAsync(customer);
        }
    }
}
