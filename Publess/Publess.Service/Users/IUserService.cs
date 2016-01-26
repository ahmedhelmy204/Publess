using Publess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Service.Users
{
   public interface IUserService
    {
        void InsertUser(User user);
    }
}
