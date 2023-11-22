using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
        public class Laptop : IConnectable, IRechargable, IDisplayable
        {
            private string brand;
            private bool isConnected;
            private int batteryLevel;

            public Laptop(string brand)
            {
                this.brand = brand;
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
                return $"Laptop Brand :{brand},battery level:{batteryLevel}%";

            }
        }
}
