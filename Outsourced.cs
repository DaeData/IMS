using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_KKellerman
{
    public class Outsourced : Part
    {


        

        private string companyName;

        public string CompanyName { get { return companyName; } set { companyName = value; } }

        


        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max)
            : base(partID, name, inStock, price, min, max)
        {
          
           
        }

        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
            : base(partID, name, inStock, price, min, max)
        {
            CompanyName = companyName;

        }











    }


}
