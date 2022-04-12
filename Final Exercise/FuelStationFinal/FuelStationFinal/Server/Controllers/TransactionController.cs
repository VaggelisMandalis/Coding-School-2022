//using FuelStation.EF.Repositories;
//using FuelStation.Model.Entities;
//using FuelStation.Shared.ViewModels;
//using Microsoft.AspNetCore.Mvc;

//namespace FuelStation.Server.Controllers;

//[ApiController]
//[Route("[controller]")]
//public class TransactionController : ControllerBase
//{
//    private readonly IEntityRepo<Transaction> _transactionRepo;

//    public TransactionController(IEntityRepo<Transaction> transactionRepo)
//    {
//        _transactionRepo = transactionRepo;
//    }

//    [HttpGet]
//    public async Task<IEnumerable<TransactionViewModel>> Get()
//    {
//        var result = await _transactionRepo.GetAllAsync();

//        var transaction = result.Select(x => new TransactionViewModel
//        {
//            ID = x.ID,
//            CustomerID = x.CustomerID,
//            EmployeeID = x.EmployeeID,
//            TotalValue = x.TotalValue
//        });

//        return transaction;
//    }

//    [HttpPost]

//    public async Task Post(TransactionViewModel transaction)
//    {
//        Transaction newTransaction = new Transaction
//        {
//            CustomerID = transaction.CustomerID,
//            EmployeeID = transaction.EmployeeID,
//            TotalValue = transaction.TotalValue,
//            TransactionLines = new()
//        };

//        foreach (var line in transaction.TransactionLines)
//        {
//            var dbLine = new TransactionLine()
//            {
//                TransactionID = line.TransactionID,
//                ItemID = line.ItemID,
//                Quantity = line.Quantity,
//                ItemPrice = line.ItemPrice,
//                NetValue = line.NetValue,
//                DiscountPercentage = line.DiscountPercentage,
//                DiscountValue = line.DiscountValue,
//                TotalValue = line.TotalValue
//            };

//            newTransaction.TransactionLines.Add(dbLine);
//        }
//        await _transactionRepo.CreateAsync(newTransaction);

//    }

//    [HttpDelete("{ID}")]
//    public async Task Delete(Guid id)
//    {
//        var _transaction = await _transactionRepo.GetByIdAsync(id);
//        _transaction.Status = !_transaction.Status;
//        await _transactionRepo.DeleteAsync(id);
//    }
//}