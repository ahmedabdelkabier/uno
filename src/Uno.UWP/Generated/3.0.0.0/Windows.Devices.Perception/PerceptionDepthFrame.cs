#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionDepthFrame : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.VideoFrame VideoFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoFrame PerceptionDepthFrame.VideoFrame is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoFrame%20PerceptionDepthFrame.VideoFrame");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionDepthFrame.VideoFrame.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Perception.PerceptionDepthFrame", "void PerceptionDepthFrame.Dispose()");
		}
		#endif
		// Processing: System.IDisposable
	}
}
