using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Data
{
    public partial class Post : BaseEntity
    {
        public string PostTitle { get; set; }
        public string PostBodyText { get; set; }
        public string PostBodyHtml { get; set; }
    }
}
