﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_KKellerman
{
    public class InHouse : Part
    {
        private int machineID;
        public int MachineID { get { return machineID;} set { machineID = value; } }

   
        public InHouse(int partID, string name, int inStock, decimal price, int min, int max)
            : base(partID, name, inStock, price, min, max)
        {
            
        }

        public InHouse(int partID, string name, int inStock, decimal price, int min, int max, int machineID)
            : base(partID, name, inStock, price, min, max)
        {
            MachineID = machineID;
        }

    }




    
}
