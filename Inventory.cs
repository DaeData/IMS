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



        public static void AddProduct(Product product)
        {
            
            products.Add(product);

        }

        public bool RemoveProduct(int productID)
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
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
                else
                {
                    return null;
                }
            }
            return null;


        }


        public static void UpdateProduct(int productID, Product changeProduct)
        {


        foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    product.Name = changeProduct.Name;
                    product.InStock = changeProduct.InStock;
                    product.Price = changeProduct.Price;
                    product.Min = changeProduct.Min;
                    product.Max = changeProduct.Max;

                }
            }   
           

        }

        public static void AddPart(Part part)
        {
            
            allparts.Add(part);
        }

        public bool DeletePart(int partID)
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
            foreach (Part part in AllParts)
            {
                if (partID == part.PartID)
                {
                    return part;
                }

            }
            return null;

        }

        public static Part UpdatePart(int partID, Part changePart)
        {
            foreach (Part part in AllParts)
            {
                if (partID == part.PartID)
                {
                    part.Name = changePart.Name;
                    part.InStock = changePart.InStock;
                    part.Price = changePart.Price;
                    part.Min = changePart.Min;
                    part.Max = changePart.Max;
                }
            }
            return null;

        }



     



        

       



    }
}













