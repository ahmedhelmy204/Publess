using Publess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Data
{
    public partial interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }

        void Insert(T entity);
    }

    public partial interface IPublessRepository<T> : IRepository<T> where T : BaseEntity { }
}
