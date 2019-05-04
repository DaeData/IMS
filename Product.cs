using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_KKellerman
{
    class Product
    {
        private static BindingList<Part> associatedParts = new BindingList<Part>();
        public static BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } }


        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product (int productID, string name,  int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public void  AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part as Part);

        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool partRemoved = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    partRemoved = true;
                }
                else
                {
                    partRemoved = false;
                }

            }
            return partRemoved;
            
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

