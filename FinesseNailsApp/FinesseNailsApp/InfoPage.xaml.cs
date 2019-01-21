//this page will access a mysql database about the employees
//it will allow users to read about everyone
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FinesseNailsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		public InfoPage ()
		{
			InitializeComponent ();
            PopulateListView();
		}


        private void PopulateListView()
        {
            //Using this method for test before SQL database implementation
            var employeeCollection = new ObservableCollection<Employee>();
      
            var employee1 = new Employee
            {
                Name = "Kevin Nguyen",
                Age = 23,

            };
            var employee2 = new Employee
            {
                Name = "John Smith",
                Age = 22,

            };
            var employee3 = new Employee
            {
                Name = "Jane Dane",
                Age = 21,

            };
            var employee4 = new Employee
            {
                Name = "Bob Baker",
                Age = 20,

            };

            employeeCollection.Add(employee1);
            employeeCollection.Add(employee2);
            employeeCollection.Add(employee3);
            employeeCollection.Add(employee4);

            EmployeeListView.ItemsSource = employeeCollection;



        }




        //Event Handlers
        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

       private void Handle_Refreshing(object sender, EventArgs e)
        {
            DisplayAlert("Refreshing Handle Clicked", "You are now refresed", "OK");
            EmployeeListView.IsRefreshing = false;
        }

        private void Handle_MoreInfoClicked(object sender, EventArgs e)
        {
            DisplayAlert("More Info Clicked", "You clicked on More Info Clicked", "OK");
        }

        void Handle_MakeAppointClicked(object sender, EventArgs e)
        {
            DisplayAlert("Appointment clicked", "You made an appointment", "OK");
        }

        private void Handle_Switch(object sender, ToggledEventArgs e)
        {
            var userSwitch = (Switch)sender;
            var grid = (Grid)userSwitch.Parent;
            var random = new Random(DateTime.Now.Millisecond);
            Color randomColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
            grid.BackgroundColor = randomColor;
        }
    }
}