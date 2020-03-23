using DesignFrame.Model;
using DesignFrame.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignFrame.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailsPage : MasterDetailPage
	{
		TbaViewModel tbaViewModel;
		public MasterDetailsPage()
		{
			InitializeComponent();
			BindingContext = tbaViewModel =  new TbaViewModel();
			IsPresented = false;
		}

		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			DetailPage  d= new DetailPage();
			Tba tba = (Tba)((ListView)sender).SelectedItem;
			tbaViewModel.Name = tba.name;
			IsPresented = false;
		}
	}
}