using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserService.Data;

namespace UserService.Repositories
{
    public class AuthManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public AuthManager(IMapper mapper, UserManager<User> manager)
        {
            _mapper = mapper;
            _userManager = manager;
        }
    }
}
