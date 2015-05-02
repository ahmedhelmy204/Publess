using Publess.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        #region Utilities

        //protected static IEngine CreateEngineInstance(PublessConfig config)
        //{
        //    //if(config!=null )

        //    return new PublessConfig();
        //}

        #endregion Utilities

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
        //    if (Singleton<IEngine>.Instance == null || forceRecreate)
        //    {
        //        var config = ConfigurationManager.GetSection("PublessConfig") as PublessConfig;
        //        Singleton<IEngine>.Instance=
        //    }
        //}

        #endregion Methods
    }
}
