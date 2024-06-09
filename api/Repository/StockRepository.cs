using api.Data;
using api.Dtos.Stock;
using api.Interfaces;
using api.Models;

namespace api.Repository
{
    public class StockRepository(ApplicationDBContext dbContext) : BaseRepository<Stock, UpdateStockRequestDto>(dbContext), IStockRepository
    {
    }
}