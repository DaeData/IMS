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
        BindingList<Part> partsAssoc = new BindingList<Part>();
        BindingSource partsGrid = new BindingSource();
        public Products()
        {
            
            InitializeComponent();

            dgAllParts.DataSource = Inventory.AllParts;
            //partsGrid.DataSource = Product.AssociatedParts;
            //dgAssocProd.DataSource = parts;

            partsGrid.DataSource = partsAssoc;
            dgAssocProd.DataSource = partsGrid;

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
            foreach (DataGridViewRow row in dgAssocProd.Rows)
            {
                if (row.Selected == true)
                {
                    Part part = (Part)dgAssocProd.CurrentRow.DataBoundItem;
                    partsGrid.Remove(part);
                    Product.RemoveAssociatedPart(part.PartID);


                }

            }

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
                partsGrid.Add(part);


            }
  

        }

        private void BtnProdSave_Click(object sender, EventArgs e)
        {
            
            Product products = new Product(Inventory.prodInc(), tbProductName.Text, int.Parse(tbProductInv.Text), decimal.Parse(tbProductPrice.Text), int.Parse(tbProductMin.Text), int.Parse(tbProductMax.Text));
            Inventory.AddProduct(products);
            foreach(Part part in partsGrid)
            {
                Product.AddAssociatedPart(part);
            }

            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }


    }
}
