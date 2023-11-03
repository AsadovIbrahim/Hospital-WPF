using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.Models
{
    public class XesteSikayeti:INotifyPropertyChanged
    {
        private Pasients ?_pasientSikayet;
        private string ?_content;

        public Pasients pasientSikayeti
        {
            get { return _pasientSikayet!; }
            set
            {
                if (_pasientSikayet != value)
                {
                    _pasientSikayet = value;
                    OnPropertyChanged(nameof(pasientSikayeti));
                }
            }
        }
        public string content
        {
            get { return _content!; }
            set
            {
                if (_content != value)
                {
                    _content = value;
                    OnPropertyChanged(nameof(content));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        }

        public override string ToString()
        {
            return content;
        }

    }
}
