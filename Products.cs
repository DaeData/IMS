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

        public Products()
        {

            InitializeComponent();

            dgAllParts.DataSource = Inventory.AllParts;
            dgAssocProd.DataSource = Product.AssociatedParts;
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
            dgAllParts.ClearSelection();
            int partSearch = int.Parse(tbAllSearch.Text);
            Product.LookupAssociatedPart(partSearch);
            dgAllParts.Rows[partSearch].Selected = true;


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
                Product.AddAssociatedPart(part);
 

            }
  

        }

        private void BtnProdSave_Click(object sender, EventArgs e)
        {
            Inventory.AddProduct(new Product((Inventory.prodInc()), tbProductName.Text, int.Parse(tbProductInv.Text), decimal.Parse(tbProductPrice.Text), int.Parse(tbProductMin.Text), int.Parse(tbProductMax.Text)));
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }


    }
}
