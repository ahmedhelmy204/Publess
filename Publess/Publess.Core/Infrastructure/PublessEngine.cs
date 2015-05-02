using Publess.Core.Configuration;
using Publess.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Infrastructure
{
    /// <summary>
    /// Engine
    /// </summary>
    public class PublessEngine : IEngine
    {
        public ContainerManager ContainerManager
        {
            get { throw new NotImplementedException(); }
        }

        public void Initialize(PublessConfig config)
        {
            throw new NotImplementedException();
        }
    }
}
