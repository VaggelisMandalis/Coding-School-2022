using FuelStation.EF.Context;
using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly FuelStationContext _context;
        public EmployeeRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Employee entity)
        {
            await _context.Employees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            _context.Employees.Remove(foundEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await _context.Employees.Where(employee => employee.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            foundEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            foundEmployee.EmployeeType = entity.EmployeeType;
            //if (entity.Fired) entity.HireDateEnd = DateTime.Now;
            //foundEmployee.Fired=entity.Fired;
            await _context.SaveChangesAsync();
        }
    }
}
