using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publess.Core.Data;
using Publess.Data;

namespace Publess.Service.Posts
{
    public class PostService : IPostService
    {
        IPublessRepository<Post> _postRepository;

        public PostService(IPublessRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public IQueryable<Post> GetPosts()
        {
            return _postRepository.Table;
        }

        public void InsertPost(Post post)
        {
            _postRepository.Insert(post);
        }
    }
}
