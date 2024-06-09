using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository : IBaseRepository<Stock, UpdateStockRequestDto>
    {
        Task<bool> StockExists(int id);
    }
}