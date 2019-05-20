using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_KKellerman
{
    class Inventory : Part
    {
        private static BindingList<Product> products = new BindingList<Product>();

        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> allparts = new BindingList<Part>();

        public static BindingList<Part> AllParts { get { return allparts; } set { allparts = value; } }


        public Inventory(int productID, string name, int inStock, decimal price, int min, int max)
            : base(productID, name, inStock, price, min, max)
        {

        }

        public static int prodCount = -1;
        public static int partCount = -1;

        public static int prodInc()
        {

            prodCount++;
            return prodCount;
        }

        public static int partInc()
        {
            partCount++;
            return partCount;
        }




        public static void AddProduct(Product product)
        {
            
            products.Add(product);


        }

        public static bool RemoveProduct(int productID)
        {
            Product product = LookupProduct(productID);
            if(product == null)
            {
                return false;
            }
            else
            {
                products.Remove(product);
                return true;
            }
     
        }


        public static Product LookupProduct(int productID)

        {
            foreach (Product product in products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
                
            }
            return null;



        }


        public static void UpdateProduct(int productID, Product changeProduct)
        {
            Product change = LookupProduct(productID);




            change.ProductID = changeProduct.ProductID;
            change.Name = changeProduct.Name;
            change.InStock = changeProduct.InStock;
            change.Price = changeProduct.Price;
            change.Min = changeProduct.Min;
            change.Max = changeProduct.Max;

           




        }

        public static void AddPart(Part part)
        {
            
            allparts.Add(part);
        }

        public static bool DeletePart(int partID)
        {
            Part part = LookupPart(partID);
            if (part == null)
            {
                return false;
            }
            else
            {
                allparts.Remove(part);
                return true;

            }


        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in allparts)
            {
                if (partID == part.PartID)
                {
                    return part;
                }

            }
            return null;

        }

        public static void UpdatePart(int partID, Part changePart)
        {
            Part part = LookupPart(partID);

            part.PartID = changePart.PartID;
            part.Name = changePart.Name;
            part.InStock = changePart.InStock;
            part.Price = changePart.Price;
            part.Min = changePart.Min;
            part.Max = changePart.Max;


        }















    }
}













