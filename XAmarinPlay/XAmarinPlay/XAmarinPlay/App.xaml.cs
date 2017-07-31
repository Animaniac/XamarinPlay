using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XAmarinPlay.ViewModel;

namespace XAmarinPlay
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XAmarinPlay.MainPage {
                BindingContext = new EventListViewModel {
                    FutureEvents = new ObservableCollection<Event>
                    {
                        new Event
                        {
                            EventDate = DateTime.Now,
                            EventName = "The first event",
                        },
                        new Event
                        {
                            EventDate = DateTime.Now.AddDays(-1),
                            EventName = "Second Event",
                        }

                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
