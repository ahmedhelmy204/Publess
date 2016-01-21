using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Publess.Data;
using Publess.Data.Models;
using Publess.Service.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Publess.Admin
{
    public static class Bootstrapper
    {
        public static void Initialise(IServiceCollection services, IConfigurationRoot Configuration)
        {
            //Instance – a specific instance is given all the time.You are responsible for its initial creation.
            //Transient – a new instance is created every time.
            //Singleton – a single instance is created and it acts like a singleton.
            //Scoped – a single instance is created inside the current scope.It is equivalent to Singleton in the current scope.

            services.AddSingleton<IDbContext, PublessEntities>();
            services.AddSingleton(typeof(IPublessDbContext), context => new PublessEntities(Configuration["Data:PublessConnectionString"]));

            services.AddSingleton(typeof(IPublessRepository<>), typeof(EfPublessRepository<>));

            services.AddSingleton<IPostService, PostService>();
        }
    }
}
