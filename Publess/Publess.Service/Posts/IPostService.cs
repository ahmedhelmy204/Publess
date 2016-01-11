﻿using Publess.Core.Data;
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
    }
}
