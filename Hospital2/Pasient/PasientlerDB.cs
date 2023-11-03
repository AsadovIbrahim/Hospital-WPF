using HOSBITAL.ViewModel;
using Hospital.ViewModel;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hospital.Pasient
{
    public class PasientlerDB
    {

        public static void Add_data_toBasa(Pasients pasients)
        {
            PasientlerDB.pasients!.Add(pasients);
            ClassQeydiyyat.WriteData(PasientlerDB.pasients, "pasients");
        }


        public static Pasients CurrentPasient { get; set; } = new();
        public static ObservableCollection<Pasients>? pasients { get; set; } = new() { };
        static PasientlerDB()
        {
            pasients = ClassQeydiyyat.ReadData<ObservableCollection<Pasients>>("pasients");
        }
        public PasientlerDB(){
            pasients = ClassQeydiyyat.ReadData<ObservableCollection<Pasients>>("pasients");
        }
    }
}
