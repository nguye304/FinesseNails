//Contact Page that will allow the user to contact Finesse Nails through many different methods including Email, Map, Phonecall and Website
// Uses the Xamarin messaging plugin


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
        private void onEmailClicked(object sender, EventArgs e){//will open email 
            var emailTask = CrossMessaging.Current.EmailMessenger;
            if (emailTask.CanSendEmail)
            {
                emailTask.SendEmail("plugins@xamarin.com", "Xamarin Messaging Plugin", "Hello from your friends at Xamarin!");

                // Send a more complex email with the EmailMessageBuilder fluent interface.
                var email = new EmailMessageBuilder()
                  .To("plugins@xamarin.com")
                  .Cc("plugins.cc@xamarin.com")
                  .Bcc(new[] { "plugins.bcc@xamarin.com", "plugins.bcc2@xamarin.com" })
                  .Subject("Xamarin Messaging Plugin")
                  .Body("Hello from your friends at Xamarin 22!")
                  .Build();

                emailTask.SendEmail(email);
            }
        }
        private void OnWebsiteClicked(object sender, EventArgs e)
        {
            var uri = new Uri("http://finessenailslashstudio.com/");
            Device.OpenUri(uri);
        }

        private void OnRatesClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PricePage());
        }
    }
}