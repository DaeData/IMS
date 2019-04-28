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
            //Inventory.DataPop();

            dgAllParts.DataSource = Inventory.AllParts;

            dgAllParts.Columns["PartID"].HeaderText = "Part ID";
            dgAllParts.Columns["Name"].HeaderText = "Name";
            dgAllParts.Columns["InStock"].HeaderText = "Inventory";
            dgAllParts.Columns["Price"].HeaderText = "Price";
            dgAllParts.Columns["Min"].HeaderText = "Min";
            dgAllParts.Columns["Max"].HeaderText = "Max";


            

            //dgAssocProd.Columns["ProductID"].HeaderText = "Product ID";
            //dgAssocProd.Columns["Name"].HeaderText = "Name";
            //dgAssocProd.Columns["InStock"].HeaderText = "Inventory";
            //dgAssocProd.Columns["Price"].HeaderText = "Price";
            //dgAssocProd.Columns["Min"].HeaderText = "Min";
            //dgAssocProd.Columns["Max"].HeaderText = "Max";

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

        private void TbAllSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnAllSearch_Click(object sender, EventArgs e)
        {
           // int sValue = int.Parse(tbAllSearch.Text);
           // Part value = Product.LookupAssociatedPart(sValue);

           //foreach(DataGridViewRow row in dgAllParts.Rows)
           // {
           //     Part part = (Part)row.DataBoundItem;
           //     if(part.PartID == value.PartID)
           //     {
           //         dgAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           //         row.Selected = true;
                    
           //     }
           // }

           
        }

        private void BtnCandidateAdd_Click(object sender, EventArgs e)
        {
            if(dgAllParts.SelectedRows.Count == 0)
            {
                return;
            }
  

        }

        private void BtnProdSave_Click(object sender, EventArgs e)
        {
            Inventory.AddProduct(new Product((Inventory.Products.Count + 1), tbProductName.Text, int.Parse(tbProductInv.Text), decimal.Parse(tbProductPrice.Text), int.Parse(tbProductMin.Text), int.Parse(tbProductMax.Text)));
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            _ = mainScreen.ShowDialog();
        }
        //if (dgAllParts.SelectedRows.Count == 0)
        //    return;

        //foreach(DataGridViewRow row in dgAllParts.SelectedRows)
        //{
        //    var selectedRow = (row.DataBoundItem);
        //    dgAssocProd.DataSource = selectedRow;
        //}
        //dgAssocProd.Columns["ProductID"].HeaderText = "Product ID";
        //dgAssocProd.Columns["Name"].HeaderText = "Name";
        //dgAssocProd.Columns["InStock"].HeaderText = "Inventory";
        //dgAssocProd.Columns["Price"].HeaderText = "Price";
        //dgAssocProd.Columns["Min"].HeaderText = "Min";
        //dgAssocProd.Columns["Max"].HeaderText = "Max";

    }
}
