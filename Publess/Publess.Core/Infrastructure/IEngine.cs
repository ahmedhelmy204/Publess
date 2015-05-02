using Publess.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the
    /// various services composing the Publess engine.
    /// Edit functionality, Modules and implementations access 
    /// most Publess functionality through this interface
    /// </summary>
     public interface IEngine
    {
         /// <summary>
         /// Container Manager
         /// </summary>
         ContainerManager ContainerManager { get; }
    }
}
