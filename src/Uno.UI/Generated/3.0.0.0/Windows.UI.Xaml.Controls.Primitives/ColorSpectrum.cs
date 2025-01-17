#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorSpectrum : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.ColorSpectrumShape Shape
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ColorSpectrumShape)this.GetValue(ShapeProperty);
			}
			set
			{
				this.SetValue(ShapeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MinValue
		{
			get
			{
				return (int)this.GetValue(MinValueProperty);
			}
			set
			{
				this.SetValue(MinValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MinSaturation
		{
			get
			{
				return (int)this.GetValue(MinSaturationProperty);
			}
			set
			{
				this.SetValue(MinSaturationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MinHue
		{
			get
			{
				return (int)this.GetValue(MinHueProperty);
			}
			set
			{
				this.SetValue(MinHueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MaxValue
		{
			get
			{
				return (int)this.GetValue(MaxValueProperty);
			}
			set
			{
				this.SetValue(MaxValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MaxSaturation
		{
			get
			{
				return (int)this.GetValue(MaxSaturationProperty);
			}
			set
			{
				this.SetValue(MaxSaturationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MaxHue
		{
			get
			{
				return (int)this.GetValue(MaxHueProperty);
			}
			set
			{
				this.SetValue(MaxHueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector4 HsvColor
		{
			get
			{
				return (global::System.Numerics.Vector4)this.GetValue(HsvColorProperty);
			}
			set
			{
				this.SetValue(HsvColorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.ColorSpectrumComponents Components
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ColorSpectrumComponents)this.GetValue(ComponentsProperty);
			}
			set
			{
				this.SetValue(ComponentsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color Color
		{
			get
			{
				return (global::Windows.UI.Color)this.GetValue(ColorProperty);
			}
			set
			{
				this.SetValue(ColorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Color), typeof(global::Windows.UI.Color), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Color)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ComponentsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Components), typeof(global::Windows.UI.Xaml.Controls.ColorSpectrumComponents), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ColorSpectrumComponents)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty HsvColorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(HsvColor), typeof(global::System.Numerics.Vector4), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Numerics.Vector4)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MaxHueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MaxHue), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MaxSaturationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MaxSaturation), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MaxValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MaxValue), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MinHueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MinHue), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MinSaturationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MinSaturation), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MinValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MinValue), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ShapeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Shape), typeof(global::Windows.UI.Xaml.Controls.ColorSpectrumShape), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.ColorSpectrumShape)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ColorSpectrum() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.ColorSpectrum", "ColorSpectrum.ColorSpectrum()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ColorSpectrum()
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Color.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Color.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.HsvColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.HsvColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinHue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinHue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxHue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxHue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinSaturation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinSaturation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxSaturation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxSaturation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Shape.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Shape.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Components.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.Components.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ColorChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ColorChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.HsvColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinHueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxHueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinSaturationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxSaturationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MinValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.MaxValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ShapeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.ColorSpectrum.ComponentsProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Primitives.ColorSpectrum, global::Windows.UI.Xaml.Controls.ColorChangedEventArgs> ColorChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.ColorSpectrum", "event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorSpectrum.ColorChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.ColorSpectrum", "event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorSpectrum.ColorChanged");
			}
		}
		#endif
	}
}
