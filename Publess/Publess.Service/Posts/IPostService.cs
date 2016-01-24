using Publess.Core.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Service.Posts
{
    public interface IPostService
    {
        IQueryable<Post> GetPosts();

        void InsertPost(Post post);
    }
}
