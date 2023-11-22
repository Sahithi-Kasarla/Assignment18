using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone : IConnectable, IRechargable, IDisplayable
    {
        private string model;
        private bool isConnected;
        private int batteryLevel;

        public Smartphone(string model)
        {
            this.model = model;
            this.isConnected = false;
            batteryLevel = 0;
        }
        public bool Connect()
        {
            isConnected = true;
            return isConnected;
        }
        public void Charge(int minutes)
        {
            //charging logic based on minutes
            batteryLevel += minutes;
        }
        public string Display()
        {
            return $"smartphone :{model},battery level:{batteryLevel}%";

        }
    }
}


