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
        private static BindingList<Part> allParts = new BindingList<Part>();
        private static BindingList<Product> associatedParts = new BindingList<Product>();
        private static BindingSource allPartsBinding = new BindingSource();
        private BindingSource assocPartsBinding = new BindingSource();
        public Products()
        {

            InitializeComponent();
            
            
            allPartsBinding.DataSource = Inventory.AllParts;
            dgAllParts.DataSource = allPartsBinding;

           


            dgAllParts.Columns["PartID"].HeaderText = "Part ID";
            dgAllParts.Columns["Name"].HeaderText = "Name";
            dgAllParts.Columns["InStock"].HeaderText = "Inventory";
            dgAllParts.Columns["Price"].HeaderText = "Price";
            dgAllParts.Columns["Min"].HeaderText = "Min";
            dgAllParts.Columns["Max"].HeaderText = "Max";



           
            assocPartsBinding.DataSource = Product.AssociatedParts;
            dgAssocProd.DataSource = assocPartsBinding;


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
                         
            int value = Convert.ToInt16(tbAllSearch.Text);
            Product.LookupAssociatedPart(value);

            foreach (DataGridViewRow row in dgAllParts.Rows)
            {
                if (Convert.ToUInt16(row.Cells["partID"].Value) == value)
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
                Part addPart = (Part)dgAllParts.CurrentRow.DataBoundItem;
                Product.AssociatedParts.Add(addPart);

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
