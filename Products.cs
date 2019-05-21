using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    public partial class Products : Form
    {
        BindingList<Part> parts = new BindingList<Part>();
        BindingSource partsGrid = new BindingSource();
        public Products()
        {
            
            InitializeComponent();

            dgAllParts.DataSource = Inventory.AllParts;
            partsGrid.DataSource = Product.AssociatedParts;
            dgAssocProd.DataSource = parts;
            dgAssocProd.Columns["PartID"].HeaderText = "Part ID";
            dgAssocProd.Columns["Name"].HeaderText = "Name";
            dgAssocProd.Columns["InStock"].HeaderText = "Inventory";
            dgAssocProd.Columns["Price"].HeaderText = "Price";
            dgAssocProd.Columns["Min"].HeaderText = "Min";
            dgAssocProd.Columns["Max"].HeaderText = "Max";


        }


        private void BtnProductCancel_Click(object sender, EventArgs e)
        {
            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
           

        }

        private void DgAllParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnAssocPartDel_Click(object sender, EventArgs e)
        {

        }

 
        private void BtnAllSearch_Click(object sender, EventArgs e)
        {
            int value = int.Parse(tbAllSearch.Text);
            foreach (DataGridViewRow row in dgAllParts.Rows)
            {
               Part part = (Part)row.DataBoundItem;
                if (part.PartID == value)
                {
                    row.Selected = true;
                }
            }


        }
                

        private void BtnCandidateAdd_Click(object sender, EventArgs e)
        {
            if(dgAllParts.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                Part part = (Part)dgAllParts.CurrentRow.DataBoundItem;
                parts.Add(part);


            }
  

        }

        private void BtnProdSave_Click(object sender, EventArgs e)
        {
            Product products = new Product(tbProductID, tbProductName, tbProductInv, tbProductPrice, tbProductMin, tbProductMax);
            
            Inventory.AddProduct(products);
            foreach(Part part in parts)
            {
                products.AddAssociatedPart(part);
            }

            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }


    }
}
