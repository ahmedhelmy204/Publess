﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Publess.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    using Publess.Core.Data;
    
    public partial class PublessEntities : DbContext, IPublessDbContext
    {
        //public PublessEntities()
        //    : base("name=PublessEntities")
        //{
        //}
    
    	public PublessEntities(string nameOrConnectionString)
                :base(nameOrConnectionString:nameOrConnectionString)
        {
    
        }
    
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            //throw new UnintentionalCodeFirstException();
        //}
    
    	 IDbSet<TEntity> IDbContext.Set<TEntity>()
         {
             return base.Set<TEntity>();
         }
    
    	 
         //protected override void OnConfiguring(DbContextOptionsBuilder options)
         //{
         //    options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
         //}
    
        public virtual IDbSet<Post> Posts { get; set; }
    }
}
