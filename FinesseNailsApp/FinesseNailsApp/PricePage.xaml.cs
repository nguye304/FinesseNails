﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinesseNailsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PricePage : ContentPage
	{
		public PricePage ()
		{
			InitializeComponent ();
		}

        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}