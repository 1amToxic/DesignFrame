using DesignFrame.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignFrame
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MasterDetailsPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
