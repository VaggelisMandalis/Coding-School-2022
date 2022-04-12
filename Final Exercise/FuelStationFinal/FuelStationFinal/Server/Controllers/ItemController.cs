using FuelStation.EF.Repositories;
using FuelStation.Models.Entities;
using FuelStationFinal.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                ItemType = x.ItemType,
                Price = x.Price,
                Cost = x.Cost
            });

        }
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(Guid id)
        {
            ItemEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _itemRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Code = existing.Code;
                model.Description = existing.Description;
                model.ItemType = existing.ItemType;
                model.Price = existing.Price;
                model.Cost = existing.Cost;


            }

            return model;
        }
        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            Item newItem = new Item
            {
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost
            };
            await _itemRepo.CreateAsync(newItem);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _itemRepo.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ActionResult> Put(ItemListViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);
            if (itemToUpdate == null) return NotFound();
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;

            await _itemRepo.UpdateAsync(item.ID, itemToUpdate);

            return Ok();
        }
    
}