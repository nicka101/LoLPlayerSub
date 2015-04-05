using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLPlayerSub
{
    public class ButtonEnabled : INotifyPropertyChanged
    {
        private bool _league_directory_valid = false;
        private bool _serialized_data_valid = false;

        public bool SubstitutionButtonEnabled
        {
            get { return LeagueDirectoryValid && SerializedDataValid; }
        }

        public bool LeagueDirectoryValid
        {
            get { return _league_directory_valid; }
            set
            {
                _league_directory_valid = value;
                OnPropertyChanged("LeagueDirectoryValid");
                OnPropertyChanged("SubstitutionButtonEnabled");
            }
        }

        public bool SerializedDataValid
        {
            get { return _serialized_data_valid; }
            set
            {
                _serialized_data_valid = value;
                OnPropertyChanged("SerializedDataValid");
                OnPropertyChanged("SubstitutionButtonEnabled");
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
