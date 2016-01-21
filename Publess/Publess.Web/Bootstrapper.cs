using Microsoft.Extensions.DependencyInjection;
using Publess.Data;
using Publess.Data.Models;
using Publess.Service.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Publess.Web
{
    public static class Bootstrapper
    {
        public static void Initialise(IServiceCollection services)
        {
            services.AddSingleton<IDbContext, PublessEntities>();

            services.AddSingleton(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddSingleton<IPostService, PostService>();
        }
    }
}
