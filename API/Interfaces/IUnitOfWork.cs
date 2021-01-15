using System.Threading.Tasks;
using API.Interfaces;

public interface IUnitWork
{
    IUserRepository UserRepository { get; }
    IMessageRepository MessageRepository { get; }
    ILikesRepository LikesRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
}