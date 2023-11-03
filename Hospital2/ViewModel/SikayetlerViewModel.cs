using HOSBITAL.Commands;
using HOSBITAL.ViewModel;
using Hospital.Views;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hospital2.ViewModel
{
    public class SikayetlerViewModel
    {
        public  static ObservableCollection<XesteSikayeti> xesteSikayetleri { get; set; } = new();
        public RealCommand closeCommand { get; set; }

        private void Close(object? sender)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Navigate(null);
        }

        public static Hekimler hekimler { get; set; } = new();

        public SikayetlerViewModel()
        {
            hekimler.xesteSikayeti = ReadData<ObservableCollection<XesteSikayeti>>("sikayetler")!;
            closeCommand = new RealCommand(Close);
        }

        public static void WriteData<T>(T? list, string filename)
        {
            JsonSerializerOptions op = new();
            string path = "C:\\Users\\Public\\";
            op.WriteIndented = true;
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
      
    }
}
