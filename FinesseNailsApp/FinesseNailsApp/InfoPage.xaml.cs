//this page will access a mysql database about the employees
//it will allow users to read about everyone
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;


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


        async private void PopulateListView()
        {
            string finesseApi = "https://google.com";
            var Uri = new Uri(finesseApi);
            var client = new HttpClient();
            EmpRootObject EmpData = new EmpRootObject();
            HttpResponseMessage response = await client.GetAsync(Uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                if (jsonContent == "{emp\":null}")
                {
                    await DisplayAlert("Error","no employees found" ,"OK");
                    return;

                }
                EmpData = JsonConvert.DeserializeObject<EmpRootObject>(jsonContent);
            }
            else
            {
                await DisplayAlert("Error", "emp json request failed", "OK");

            }
            EmployeeListView.ItemsSource = new ObservableCollection<Employee>(EmpData.Employees);
            
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