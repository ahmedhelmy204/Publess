using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Publess.Core.Infrastructure.DependencyManagement
{
    public class ContainerManager
    {
        private readonly IUnityContainer _container;

        public ContainerManager(IUnityContainer container)
        {
            _container = container;
        }

        public IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
