using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class LikeRepository : ILikesRepository
    {
        private readonly DataContext _context;
        public LikeRepository(DataContext context)
        {
            _context = context;

        }
        Task<UserLike> ILikesRepository.GetUserLike(int sourceUserId, int likedUserId)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<LikeDto>> ILikesRepository.GetUserLikes(string predicate, int userId)
        {
            throw new System.NotImplementedException();
        }

        Task<AppUser> ILikesRepository.GetUserWithLikes(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}