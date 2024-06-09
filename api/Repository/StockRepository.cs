using System.Linq.Expressions;
using api.Data;
using api.Dtos.Stock;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository(ApplicationDBContext dbContext) : BaseRepository<Stock, UpdateStockRequestDto>(dbContext), IStockRepository
    {
        public override async Task<List<Stock>> GetAllAsync()
        {
            var query = _dbContext.Stock.Include(c => c.Comments);

            return await query.ToListAsync();
        }
    }
}