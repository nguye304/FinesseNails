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
	public partial class AppointmentPage : ContentPage
	{
		public AppointmentPage ()
		{
			InitializeComponent ();
		}

        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}