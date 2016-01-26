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


            string metaData = "res://*/Models.PublessModel.csdl|res://*/Models.PublessModel.ssdl|res://*/Models.PublessModel.msl";
            string dataSource = ".";
            string initialCatalog = "Publess";




            services.AddSingleton(typeof(IPublessDbContext), context => new PublessEntities(CreateConnectionString(metaData, dataSource, initialCatalog)));

            services.AddSingleton(typeof(IPublessRepository<>), typeof(EfPublessRepository<>));

            services.AddSingleton<IPostService, PostService>();
            services.AddSingleton<IUserService, UserService>();
        }

        public static string CreateConnectionString(string metaData, string dataSource, string initialCatalog)
        {
            const string appName = "EntityFramework";
            const string providerName = "System.Data.SqlClient";

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = dataSource;
            sqlBuilder.InitialCatalog = initialCatalog;
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.ApplicationName = appName;

            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
            efBuilder.Metadata = metaData;
            efBuilder.Provider = providerName;
            efBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;

            return efBuilder.ConnectionString;
        }
    }
}
