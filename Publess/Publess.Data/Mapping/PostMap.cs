using Publess.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Data.Mapping
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            // key
            HasKey(t => t.PostId);
            // properties
            Property(t => t.Title).IsRequired();
            Property(t => t.BodyHtml).IsRequired();
            Property(t => t.BodyText);
            Property(t => t.InsertedOn).IsRequired();
            Property(t => t.UpdatedOn);
            // table
            ToTable("Post");
        }
    }
}
