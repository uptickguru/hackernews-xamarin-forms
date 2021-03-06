﻿using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HackerNewsXamarinForms
{
	public partial class HackerNewsXamarinFormsPage : ContentPage
	{
		public ObservableCollection<string> ListViewItems { get; set; }

		public HackerNewsXamarinFormsPage()
		{
			InitializeComponent();
			ListViewItems = new ObservableCollection<string> { "one", "two", "three" };
			BindingContext = this;
		}

		public void OnAddButtonClicked(object sender, EventArgs e)
		{
			ListViewItems.Add(DateTime.Now.ToString());
			// OnPropertyChanged("ListViewItems");
		}

	}
}

