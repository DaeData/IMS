using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    class Product 
    {
        
        private static BindingList<Part> associatedParts = new BindingList<Part>();
        public static BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } }


        private TextBox tbProductID;
        private TextBox tbProductName;
        private TextBox tbProductInv;
        private TextBox tbProductPrice;
        private TextBox tbProductMin;
        private TextBox tbProductMax;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Product() { }
        public Product(int productID, string name, int inStock, decimal price, int min, int max)


        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product(TextBox tbProductID, TextBox tbProductName, TextBox tbProductInv, TextBox tbProductPrice, TextBox tbProductMin, TextBox tbProductMax)
        {
            this.tbProductID = tbProductID;
            this.tbProductName = tbProductName;
            this.tbProductInv = tbProductInv;
            this.tbProductPrice = tbProductPrice;
            this.tbProductMin = tbProductMin;
            this.tbProductMax = tbProductMax;
        }

        public void  AddAssociatedPart(Part part)
        {
           

                AssociatedParts.Add(part);

            

        }

        public static bool RemoveAssociatedPart(int partID)
        {
           Part part = LookupAssociatedPart(partID);
            if(part == null)
            {
                return false;
            }
            else
            {

                AssociatedParts.Remove(part);
                return true;
            }




   
            
        }

        public static Part LookupAssociatedPart(int partID)

        {

            foreach (Part part in AssociatedParts)
            {

                if (partID == part.PartID)
                {
                    return part;

                }
            }
            return null;
      

        }
        
     
            



    }
}

