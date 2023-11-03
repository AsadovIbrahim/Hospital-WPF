using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;
using System.ComponentModel;
using HOSBITAL.Pages;
using System.Windows.Controls;
using System.Windows.Media;
using Hospital.Pages;
using HOSBITAL.Commands;
using HOSBITAL.Views;
using Hospital.Pasient;
using System.IO;
using System.Text.Json;
using Hospital2.Models;

namespace HOSBITAL.ViewModel
{
    public class ClassQeydiyyat : INotifyPropertyChanged
    {
        public RealCommand? QeydiyyatCommand { get; set; }
        public RealCommand? male { get; set; }
        public RealCommand? female { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool check = false;
     

        public Pasients pasient { get; set; } = new();
        private void QeydiyyatdanKec(object? sender)
        {
            if (string.IsNullOrEmpty(pasient.Name))
            {
                Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.Surname))
            {
                Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.fathersName))
            {
                Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.birthday))
            {
                Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.seriyaID))
            {
                Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (pasient.Gender != null)
            {
                check = true;
                Qeydiyyat.qeydiyyat_pasient!.maleradiobtn.ClearValue(Border.BorderBrushProperty);
                Qeydiyyat.qeydiyyat_pasient.femaleradiobtn.ClearValue(Border.BorderBrushProperty);
            }
           
            if (string.IsNullOrEmpty(pasient.Number))
            {
                Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.Mail))
            {
                Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.Password))
            {
                Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(pasient.againPassword))
            {
                Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }


            var greenBrush = new SolidColorBrush(Colors.Green);

            TextBox[] textBoxes = {
    Qeydiyyat.qeydiyyat_pasient!.nameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.surnameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.fathersnameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.seriyaIdTxtBox,
    Qeydiyyat.qeydiyyat_pasient.numberTxtBox,
    Qeydiyyat.qeydiyyat_pasient.mailTxtBox,
    Qeydiyyat.qeydiyyat_pasient.passwordTxtBox,
    Qeydiyyat.qeydiyyat_pasient.againpasswordTxtBox
};

            bool allTextboxesValid = true;

            foreach (var textBox in textBoxes)
            {
                if (textBox.BorderBrush is not SolidColorBrush brush || brush.Color != greenBrush.Color)
                {
                    allTextboxesValid = false;
                    break;
                }
            }

            if (allTextboxesValid)
            {
                PasientlerDB.Add_data_toBasa(pasient);

                Girish.girish!.MainFrame.Content = new Login();
            }



        }
        private void Male(object? sender)
        {
            pasient.Gender = "kisi";
        }
        private void Female(object? sender)
        {
            pasient.Gender = "qadin";
        }

        public static void WriteData<T>(T? list, string filename)
        {
            JsonSerializerOptions op = new();
            op.WriteIndented = true;
            string path = "C:\\Users\\Public\\";
            File.WriteAllText(path+filename + ".json", JsonSerializer.Serialize(list, op));
        }

        public static T? ReadData<T>(string filename) where T : new()
        {
            T? readData = new T(); 

            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;
            string path = "C:\\Users\\Public\\";

            using FileStream fs = new FileStream(path+filename + ".json", FileMode.OpenOrCreate);
            if (fs.Length != 0) readData = JsonSerializer.Deserialize<T>(fs, op);

            return readData;
        }
        public ClassQeydiyyat()
        {
            QeydiyyatCommand = new(QeydiyyatdanKec);
            male = new(Male);
            female = new(Female);
        }


    }
}
