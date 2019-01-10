using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinesseNailsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage (){
			InitializeComponent ();
        }

        public void OnMapClick() { //will open link to google maps for finesse nails
            //note: consider showing the map too
            var uri = new Uri("http://maps.google.com/maps?saddr=Google+Inc,+8th+Avenue,+New+York,+NY&daddr=John+F.+Kennedy+International+Airport,+Van+Wyck+Expressway,+Jamaica,+New+York&directionsmode=transit");
            Device.OpenUri(uri);
        }

        private void OnCalledClicked(object sender, EventArgs e){//will call finesse nails store number
            var phoneNumber = "+8042221111";
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
               phoneDialer.MakePhoneCall(phoneNumber);
            
        }

        private void OnWebsiteClicked(object sender, EventArgs e)
        {
            var uri = new Uri("http://finessenailslashstudio.com/");
            Device.OpenUri(uri);
        }
    }
}