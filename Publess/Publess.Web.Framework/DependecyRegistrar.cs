using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Publess.Data;
using Publess.Data.Models;
using Publess.Service.Posts;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using Publess.Service.Users;

namespace Publess.Web.Framework
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public static class DependecyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="services">Services Collection</param>
        /// <param name="Configuration">Configuration</param>
        public static void Register(IServiceCollection services, IConfigurationRoot Configuration)
        {
            //Instance – a specific instance is given all the time.You are responsible for its initial creation.
            //Transient – a new instance is created every time.
            //Singleton – a single instance is created and it acts like a singleton.
            //Scoped – a single instance is created inside the current scope.It is equivalent to Singleton in the current scope.

            //services.AddSingleton<IDbContext, PublessEntities>();
            //services.AddSingleton(typeof(IPublessDbContext), context => new PublessEntities(Configuration["Data:PublessConnectionString"]));


           // string metaData = "res://*/Models.PublessModel.csdl|res://*/Models.PublessModel.ssdl|res://*/Models.PublessModel.msl";

            services.AddSingleton(typeof(IPublessDbContext), context =>  PublessEntities.Create(Configuration["Data:PublessConnectionString"]));

            services.AddSingleton(typeof(IPublessRepository<>), typeof(EfPublessRepository<>));

            services.AddSingleton<IPostService, PostService>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}
