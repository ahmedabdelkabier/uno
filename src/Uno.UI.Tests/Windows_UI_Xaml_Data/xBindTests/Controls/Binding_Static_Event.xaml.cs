﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Tests.Windows_UI_Xaml_Data.xBindTests.Controls
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Binding_Static_Event : Page
	{
		public Binding_Static_Event()
		{
			this.InitializeComponent();
		}

	}

	public static class Binding_Static_Event_Class
	{

		public static int CheckedRaised { get; private set; }
		public static int UncheckedRaised { get; private set; }

		public static void OnCheckedRaised()
		{
			CheckedRaised++;
		}

		public static void OnUncheckedRaised(object sender, RoutedEventArgs args)
		{
			UncheckedRaised++;
		}
	}
}
