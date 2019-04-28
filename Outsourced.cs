using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_KKellerman
{
    public class Outsourced : Part
    {
        private string companyname;

        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyname)
            : base(partID, name, inStock, price, min, max)
        {
            CompanyName = companyname;
        }

        public string CompanyName { get; set; }







    }


}
