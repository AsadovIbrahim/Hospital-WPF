using Hospital.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Hospital2.Models
{
    public class Pasients:INotifyPropertyChanged
    {
        private string? _Name;

        public string Name
        {
            get { return _Name!; }
            set
            {
                if (value.Length < 3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string? _Surname;
        public string Surname
        {
            get { return _Surname!; }
            set
            {
                if (!Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        private string? _fathersName;

        public string fathersName
        {
            get { return _fathersName!; }
            set
            {
                if (value.Length < 3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _fathersName = value;
                OnPropertyChanged(nameof(fathersName));
            }
        }

        private string? _birthday;
        public string birthday
        {
            get { return _birthday!; }
            set
            {

                if (!Regex.Match(value!, @"^(0[1-9]|[1-2][0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _birthday = value;
                OnPropertyChanged(nameof(seriyaID));
            }
        }

        private string? _seriyaID;
        public string seriyaID
        {
            get { return _seriyaID!; }
            set
            {

                if (!Regex.Match(value!, @"^[A-Z]{2}\d{7}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _seriyaID = value;
                OnPropertyChanged(nameof(seriyaID));
            }
        }
        private string? _Gender;
        public string Gender
        {
            get { return _Gender!; }
            set { _Gender = value; OnPropertyChanged(nameof(Gender)); }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? _Number;
        public string Number
        {
            get { return _Number!; }
            set
            {
                if (Regex.Match(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                _Number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        private string? _Mail;

        public string Mail
        {
            get { return _Mail; }
            set
            {
                if (!Regex.Match(value!, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);

                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Mail = value;
                OnPropertyChanged(nameof(Mail));
            }
        }


        private string? _Password;
        public string Password
        {
            get { return _Password!; }
            set
            {

                if (value.Length < 6)
                {
                    Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string? _againPassword;
        public string againPassword
        {
            get { return _againPassword!; }
            set
            {
                if (value != Password)
                {
                    Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _againPassword = value;
                OnPropertyChanged(nameof(againPassword));
            }
        }
    }
}
