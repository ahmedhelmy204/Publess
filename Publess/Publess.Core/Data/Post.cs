using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Data
{
    public class Post : BaseEntity
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string BodyHtml { get; set; }
        public string BodyText { get; set; }
    }
}
