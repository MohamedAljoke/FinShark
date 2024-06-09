using api.Data;
using api.Dtos.Comment;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository(ApplicationDBContext dbContext) : ICommentRepository
    {
        private readonly ApplicationDBContext _dbContext = dbContext;

        public async Task<Comment> CreateAsync(Comment model)
        {
            await _dbContext.Comment.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var commentModel = await _dbContext.Comment.FirstOrDefaultAsync(x => x.Id == id);
            if (commentModel == null)
            {
                return null;
            }
            _dbContext.Comment.Remove(commentModel);
            await _dbContext.SaveChangesAsync();
            return commentModel;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _dbContext.Comment.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _dbContext.Comment.FindAsync(id);
        }

        public async Task<Comment?> UpdateAsync(int id, UpdateCommentDto updateDto)
        {
            var existingComment = await _dbContext.Comment.FirstOrDefaultAsync(x => x.Id == id);
            if (existingComment == null)
            {
                return null;
            }
            existingComment.Title = updateDto.Title;
            existingComment.Content = updateDto.Content;
            existingComment.CreatedOn = updateDto.CreatedOn;

            await _dbContext.SaveChangesAsync();
            return existingComment;
        }
    }
}