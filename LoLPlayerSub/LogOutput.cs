using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLPlayerSub
{
    public class LogOutput : INotifyPropertyChanged
    {
        ObservableCollection<string> _output = new ObservableCollection<string>();

        public ObservableCollection<string> Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
                OnPropertyChanged("Output");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
