using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAmarinPlay
{
   public class Event: INotifyPropertyChanged
    {
        public String EventName { get; set; }
        public DateTime EventDate { get; set; }
        public Event()
        {
                
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}