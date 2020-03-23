using DesignFrame.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DesignFrame.ViewModel
{
	class TbaViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private Tba selectedTba { get; set; }
		private string _name = "a";
		public string Name
		{
			get => _name;
			set
			{
				if (_name != value)
				{
					_name = value;
				}
				RaisePropertyChanged("Name");
				
			}
		}
		public Tba SelectedTba {
			get => selectedTba;
			set
			{
					selectedTba = value;
				
			}
		}
		private ObservableCollection<Tba> _tbas;
		public ObservableCollection<Tba> Tbas
		{
			get => _tbas;
			set
			{
				_tbas = value;
				RaisePropertyChanged("Tbas");
			}
		}
		public TbaViewModel()
		{
			Tbas = new ObservableCollection<Tba>
			{
				new Tba{ id = 1,name ="a",degree = 100, type="x"},
				new Tba{ id = 2,name ="b",degree = 101, type="y"},
				new Tba{ id = 3,name ="c",degree = 102, type="z"},
			};
		}
		void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
