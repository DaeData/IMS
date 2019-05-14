using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AddProduct(new Product(Inventory.prodInc(), "Red Bicycle", 15, 11.44m, 1, 25));
            Inventory.AddProduct(new Product(Inventory.prodInc(), "Yellow Bicycle", 19, 9.66m, 1, 20));
            Inventory.AddProduct(new Product(Inventory.prodInc(), "Blue Bicycle", 5, 12.77m, 1, 25));
            

            Inventory.AddPart(new InHouse(Inventory.partInc(), "Wheel", 15, 12.11m, 5, 25,0001));
            Inventory.AddPart(new InHouse(Inventory.partInc(), "Pedal", 11, 8.33m, 5, 25, 0002));
            Inventory.AddPart(new Outsourced(Inventory.partInc(), "Chain", 12, 8.33m, 5, 25, "Chains LTD."));
            Inventory.AddPart(new Outsourced(Inventory.partInc(), "Seat", 8, 4.55m, 2, 15, "Seats Inc."));
           
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
