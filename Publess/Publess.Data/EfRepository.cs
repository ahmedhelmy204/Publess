using Publess.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Data
{
    public partial class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public EfRepository(IDbContext context)
        {
            this._context = context;
        }

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
    }

    public partial class EfPublessRepository<T> : EfRepository<T>, IPublessRepository<T> where T : BaseEntity
    {
        public EfPublessRepository(IDbPublessContext context)
            : base(context)
        {

        }
    }
}
