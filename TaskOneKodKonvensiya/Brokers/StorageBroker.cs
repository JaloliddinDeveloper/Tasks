﻿//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//==================================================

using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TaskOneKodKonvensiya.Brokers
{
    public partial class StorageBroker : EFxceptionsContext
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }
        private async ValueTask<T> InsertAsync<T>(T @object) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            broker.Entry(@object).State = EntityState.Added;
            broker.SaveChangesAsync();

            return @object;
        }

        private IQueryable<T> SelectAll<T>() where T : class
        {
            using var broker = new StorageBroker(this.configuration);

            return broker.Set<T>();
        }

        private async ValueTask<T> SelectAsync<T>(params object[] objectIds) where T : class
        {
            using var broker = new StorageBroker(this.configuration);

            return await broker.FindAsync<T>(objectIds);
        }

        private async ValueTask<T> UpdateAsync<T>(T @object) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            broker.Entry(@object).State = EntityState.Modified;
            broker.SaveChangesAsync();

            return @object;
        }

        private async ValueTask<T> DeleteAsync<T>(T @object) where T : class 
        {
            using var broker= new StorageBroker(this.configuration);
            broker.Entry(@object).State = EntityState.Deleted;
            broker.SaveChangesAsync();

            return @object;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=TaskOneKKDB;Integrated Security=True;TrustServerCertificate=True");

        //public override void Dispose() { }
    }
}
