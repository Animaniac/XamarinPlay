using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAmarinPlay.ViewModel
{
    public class EventListViewModel:INotifyPropertyChanged
    {
        
        public ObservableCollection<Event> FutureEvents { get; set; }

        public String NewEventName { get; set; }
        public DateTime NewEvenDate { get; set; }
        public Command AddNewEvent { get; set; }
        public Command ShowAddEventControls { get; set; }
        public Command SaveChangedEvent { get; set; }
        public Command CancelAddNewEvent { get; set; }
        public bool AddEventControlsVisible { get; set; }

        public Command ShowEditEventControls { get; set; }
        public Command CloseEditEventControls { get; set; }
        public Command EditSelectedEvent { get; set; }
        public bool EditEventcontrolsVisible { get; set; }
        public Event CurrentlySelectedEvent { get; set; }

        public Command DeleteSelectedEvent { get; set; }
        
        
       
        
        public EventListViewModel()
        {
            EditSelectedEvent = new Command(EditSelectedEventCommand);
            DeleteSelectedEvent = new Command(DeleteSelectedEventCommand);
            AddNewEvent = new Command(AddEvent);            
            ShowAddEventControls = new Command(x => AddEventControlsVisible = true);
            ShowEditEventControls = new Command(ShowEventCrontrolsAndPopulateWithCurrentEventDetailsx);
            CancelAddNewEvent = new Command(CancelAddEvent);
            CloseEditEventControls = new Command(x => EditEventcontrolsVisible = false);

        }

        private void ShowEventCrontrolsAndPopulateWithCurrentEventDetailsx(object obj)
        {
            CurrentlySelectedEvent = obj as Event;
            EditEventcontrolsVisible = true;
        }

        private void EditSelectedEventCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedEventCommand(object obj)
        {
            FutureEvents.Remove(obj as Event);
        }

        private void CancelAddEvent(object obj)
        {
            AddEventControlsVisible = false;
            NewEventName = null;
            NewEvenDate = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void AddEvent(object ob)
        {
            var newEvent = new Event()
            {
                EventName = NewEventName,
                EventDate = NewEvenDate,
            };
            FutureEvents.Add(newEvent);
        }
    }
}
