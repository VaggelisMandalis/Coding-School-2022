using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopEFLibrary.Repositories
{
    internal class CustomerRepo : IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var customer = new PetShopContext();
            customer.Customers.Add(entity);
            await customer.SaveChangesAsync();
        }

        public  async Task Delete(Guid id)
        {
            using var customer = new PetShopContext();
            var foundCustomer = customer.Customers.SingleOrDefault(todo => todo.ID == id);
            if (foundCustomer is null)
                return;

            customer.Customers.Remove(foundCustomer);
            await customer.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var customer = new PetShopContext();
            return customer.Customers.ToList();
        }

        public Customer? GetById(Guid id)
        {
            using var customer = new PetShopContext();
            return customer.Customers.Where(todo => todo.ID == id).SingleOrDefault();
        }

        public Task Update(Guid id, Customer entity)
        {
            using var customer = new PetShopContext();
            var foundTodo = customer.Customers.Include(todo => todo.Detail).SingleOrDefault(todo => todo.Id == id);
            if (foundTodo is null)
                return;
            if (!foundTodo.Finished && entity.Finished)
            {
                foundTodo.Detail.FinishDate = DateTime.Now;
            }
            foundTodo.Finished = entity.Finished;
            foundTodo.Title = entity.Title;
            await context.SaveChangesAsync();
        }
    }


}
