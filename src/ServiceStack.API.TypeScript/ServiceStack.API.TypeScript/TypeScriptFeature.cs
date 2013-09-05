using System;
using System.Linq;
using System.Text.RegularExpressions;
using ServiceStack.WebHost.Endpoints;

namespace ServiceStack.API.TypeScript
{
    public class TypeScriptFeature : IPlugin
    {
        /// <summary>
        /// Gets or sets <see cref="Regex"/> pattern to filter available resources. 
        /// </summary>
        public string ResourceFilterPattern { get; set; }

        public bool UseCamelCaseModelPropertyNames { get; set; }

        public bool UseLowercaseUnderscoreModelPropertyNames { get; set; }

        public bool DisableAutoDtoInBodyParam { get; set; }

        public void Register(IAppHost appHost)
        {
            appHost.RegisterService(typeof(TypeScriptService), new[]{"/typescript"});
        }

        public static bool IsEnabled
        {
            get { return EndpointHost.Plugins.Any(x => x is TypeScriptFeature); }
        }
    }
}
