using Publess.Core.Data;
using Publess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Service
{
    public class PostService : IPostService
    {
        private IRepository<Post> _postRepository;

        public PostService(IRepository<Post> postRepository)
        {
            this._postRepository = postRepository;
        }

        public IQueryable<Post> GetPosts(int pageNo, int pageSize)
        {
            return _postRepository.Table
                .OrderByDescending(p => p.InsertedOn)
                .Skip(pageNo * pageSize)
                .Take(pageSize);
        }

        public int TotalPosts()
        {
            return _postRepository.Table.Count();
        }
    }
}
