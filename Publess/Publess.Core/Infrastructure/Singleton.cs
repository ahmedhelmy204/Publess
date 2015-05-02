using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publess.Core.Infrastructure
{
    /// <summary>
    /// A statically compiled "singleton" used to store objects throughout 
    /// the lifetime of the app domain. Not so much singleton in the 
    /// pattern's sense of the word as a standardized way to store
    /// single instances.
    /// </summary>
    /// <typeparam name="T">The type of object to store.</typeparam>
    /// <remarks>Access to the instance is not synchronized</remarks>
    public class Singleton<T> : Singleton
    {
        static T instance;

        public static T Instance
        {
            get { return instance; }
            set
            {
                instance = value;
                AllSingletons[typeof(T)] = value;
            }
        }

    }

    /// <summary>
    /// Provides access to all "singletons" stored by <see cref="Singleton{T}"/>
    /// </summary>
    public class Singleton
    {
        static Singleton()
        {
            allSingletons = new Dictionary<Type, object>();
        }

        static readonly IDictionary<Type, object> allSingletons;

        /// <summary>
        /// Dictionary of type to singleton instances.
        /// </summary>
        public static IDictionary<Type, object> AllSingletons
        {
            get
            {
                return allSingletons;
            }
        }
    }
}
