using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Publess.Core.Configuration
{
    /// <summary>
    /// Represents a PublessConfig
    /// URL:  https://msdn.microsoft.com/en-us/library/system.configuration.iconfigurationsectionhandler(v=vs.110).aspx
    /// </summary>
    public partial class PublessConfig:IConfigurationSectionHandler
    {
        /// <summary>
        /// Creates a configuration section handler.
        /// </summary>
        /// <param name="parent">Parent object.</param>
        /// <param name="configContext">Configuration context object.</param>
        /// <param name="section">Section XML node.</param>
        /// <returns>The created section handler object.</returns>
        public object Create(object parent, object configContext, XmlNode section)
        {
            var config = new PublessConfig();

            var engineNode = section.SelectSingleNode("Engine");
            if (engineNode != null && engineNode.Attributes != null)
            {
                var attribute = engineNode.Attributes["Type"];
                if (attribute != null)
                    config.EngineType = attribute.Value;
            }

            return config;
        }

        /// <summary>
        /// A custom <see cref="IEngine"/> to manage the application 
        /// instead of the default
        /// </summary>
        public string EngineType { get; set; }
    }
}
