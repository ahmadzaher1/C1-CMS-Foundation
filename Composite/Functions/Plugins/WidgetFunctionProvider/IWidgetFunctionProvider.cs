using System.Collections.Generic;

using Composite.Functions.Plugins.WidgetFunctionProvider.Runtime;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;


namespace Composite.Functions.Plugins.WidgetFunctionProvider
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    [CustomFactory(typeof(WidgetFunctionProviderCustomFactory))]
    [ConfigurationNameMapper(typeof(WidgetFunctionProviderDefaultNameRetriever))]
	public interface IWidgetFunctionProvider
	{
        /// <exclude />
        WidgetFunctionNotifier WidgetFunctionNotifier { set; }

        /// <exclude />
        IEnumerable<IWidgetFunction> Functions { get; }
	}
}
