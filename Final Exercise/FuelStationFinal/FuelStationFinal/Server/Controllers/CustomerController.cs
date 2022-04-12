using FuelStation.EF.Repositories;
using FuelStation.Models.Entities;
using FuelStationFinal.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IEntityRepo<Customer> _customerRepo;

    public CustomerController(IEntityRepo<Customer> customerRepo)
    {
        _customerRepo = customerRepo;
    }
    
    [HttpGet]
    public async Task<IEnumerable<CustomerListViewModel>> GetTrue()
    {
        var result = await _customerRepo.GetAllAsync();

        return result.Select(x => new CustomerListViewModel
        {
            ID = x.ID,
            Name = x.Name,
            Surname = x.Surname,
            CardNumber = x.CardNumber
        });
    }
    [HttpGet("{id}")]
    public async Task<CustomerEditViewModel> Get(Guid id)
    {
        CustomerEditViewModel model = new();
        if (id != Guid.Empty)
        {
            var existing = await _customerRepo.GetByIdAsync(id);
            model.ID = existing.ID;
            model.Name = existing.Name;
            model.Surname = existing.Surname;
            model.CardNumber = existing.CardNumber;

        }

        return model;
    }

    //[HttpGet("statusfalse")]
    //public async Task<IEnumerable<CustomerViewModel>> GetFalse()
    //{
    //    var result = await _customerRepo.GetAllAsync();

    //    return result.FindAll(x => x.Status == false).Select(x => new CustomerViewModel
    //    {
    //        ID = x.ID,
    //        Name = x.Name,
    //        Surname = x.Surname,
    //        CardNumber = x.CardNumber
    //    });
    //}

    [HttpPost]

    public async Task Post(CustomerListViewModel customer)
    {
        Customer newCustomer = new Customer
        {
            Name = customer.Name,
            Surname = customer.Surname,
            CardNumber = customer.CardNumber
        };

        await _customerRepo.CreateAsync(newCustomer);

    }

    [HttpDelete("{ID}")]
    public async Task Delete(Guid id)
    {
        await _customerRepo.DeleteAsync(id);
    }


    [HttpPut]
    public async Task<ActionResult> Put(CustomerEditViewModel customer)
    {
        var itemToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
        if (itemToUpdate == null) return NotFound();
        itemToUpdate.Name = customer.Name;
        itemToUpdate.Surname = customer.Surname;
        itemToUpdate.CardNumber = customer.CardNumber;

        await _customerRepo.UpdateAsync(customer.ID, itemToUpdate);

        return Ok();
    }
}
