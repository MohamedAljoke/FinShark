using api.Data;
using api.Dtos.Comment;
using api.Interfaces;
using api.Models;

namespace api.Repository
{
    public class CommentRepository(ApplicationDBContext dbContext) : BaseRepository<Comment, UpdateCommentDto>(dbContext), ICommentRepository
    {
    }
}