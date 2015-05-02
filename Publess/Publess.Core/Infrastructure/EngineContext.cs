using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Infrastructure
{
    /// <summary>
    /// Provides access to the singleton instance of the Publess engine.
    /// </summary>
    public class EngineContext
    {
        #region Methods

        // really is the same as using lock(this) on the whole method
        /// <summary>
        /// Initialize a static instance of the Publess factory
        /// </summary>
        /// <param name="forceRecreate">Creates a new factory instance even though the factory has been previously initialized.</param>
        /// <returns></returns>
        //[MethodImpl(MethodImplOptions.Synchronized)]
        //public static IEngine Initialize(bool forceRecreate)
        //{

        //}

        #endregion Methods
    }
}
