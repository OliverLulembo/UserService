using Microsoft.AspNetCore.Identity;
using UserService.DTOs;

namespace UserService.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(UserRegistrationDTO user);
    }
}
