#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DebugSettings 
	{
		// Skipping already declared property IsTextPerformanceVisualizationEnabled
		// Skipping already declared property IsBindingTracingEnabled
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool FailFastOnErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DebugSettings.FailFastOnErrors is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DebugSettings", "bool DebugSettings.FailFastOnErrors");
			}
		}
		#endif
		// Skipping already declared property EnableFrameRateCounter
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.EnableFrameRateCounter.get
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.EnableFrameRateCounter.set
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.IsBindingTracingEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.IsBindingTracingEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.IsTextPerformanceVisualizationEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.IsTextPerformanceVisualizationEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.FailFastOnErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.FailFastOnErrors.set
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.BindingFailed.add
		// Forced skipping of method Microsoft.UI.Xaml.DebugSettings.BindingFailed.remove
		// Skipping already declared event Microsoft.UI.Xaml.DebugSettings.BindingFailed
	}
}
