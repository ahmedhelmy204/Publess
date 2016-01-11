using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        public int Id { get; set; }

        public DateTime InsertedOn { get; set; }
        public Nullable<int> InsertedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
