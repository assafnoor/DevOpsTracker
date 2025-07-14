
using Identity.Domain.Users;

namespace Identity.Application.Common.Interface.Persistence;
public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
