﻿using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class CustomerService : ICustomerService
    {
        private IMapper mapper;
        private readonly IWorkForUnit database;
        
        public CustomerService(IWorkForUnit database)
        {
            this.database = database;
        }

        public async Task<CustomerDTO> GetAsync(int id) =>
               mapper.Map<CustomerDTO>(await database.Customers.GetAsync(id));

        public async Task CreateAsync(CustomerDTO customer)
        {
            database.Customers.Create(mapper.Map<Customer>(customer));
            await database.SaveAsync();
        }

        public async Task UpdateAsync(CustomerDTO newCustomer)
        {
            var data = await database.Customers.GetAsync(newCustomer.Id);

            if(data != null)
            {
                database.Customers.Update(mapper.Map<Customer>(newCustomer));
                await database.SaveAsync();
            }     
        }

        public async Task DeleteAsync(int id)
        {
            await database.Customers.DeleteAsync(id);
            await database.SaveAsync() ;
        }     
            
    }
}
