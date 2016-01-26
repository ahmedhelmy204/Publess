using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publess.Core.Domain.Users;
using Publess.Data;

namespace Publess.Service.Users
{
    public class UserService : IUserService
    {
        IPublessRepository<User> _userRepository;

        public UserService(IPublessRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }
    }
}
