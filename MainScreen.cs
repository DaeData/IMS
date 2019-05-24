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
    public partial class MainScreen : Form
    {
       // private object btnSave;

        public MainScreen()
        {

            InitializeComponent();

            MainScreen_Load();
            
           

        }
        //Define how the data will be bound and format the data grids.
        public void MainScreen_Load()
        {
             
            BindingSource partBind = new BindingSource
            {
                DataSource = Inventory.AllParts
            };

            dgPartMain.DataSource = partBind;

            dgPartMain.Columns["PartID"].HeaderText = "Part ID";
            dgPartMain.Columns["Name"].HeaderText = "Name";
            dgPartMain.Columns["InStock"].HeaderText = "Inventory";
            dgPartMain.Columns["Price"].HeaderText = "Price";
            dgPartMain.Columns["Min"].HeaderText = "Min";
            dgPartMain.Columns["Max"].HeaderText = "Max";
            

            BindingSource prodBind = new BindingSource
            {
                DataSource = Inventory.Products
            };
            dgProductMain.DataSource = prodBind;

            dgProductMain.Columns["ProductID"].HeaderText = "Product ID";
            dgProductMain.Columns["Name"].HeaderText = "Name";
            dgProductMain.Columns["InStock"].HeaderText = "Inventory";
            dgProductMain.Columns["Price"].HeaderText = "Price";
            dgProductMain.Columns["Min"].HeaderText = "Min";
            dgProductMain.Columns["Max"].HeaderText = "Max";

            
            dgPartMain.ClearSelection();
            dgProductMain.ClearSelection();


           

        }


        //Close the Application.
        private void Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        //Go to the add Product form.
        private void BtnProductAdd_Click(object sender, EventArgs e)
        {

            Hide();
            Products prodForm = new Products();
            prodForm.Show();
            

        }
        //Go to the Modify Product form and load the selected row into the text boxes.
        private void BtnProductModify_Click(object sender, EventArgs e)
        {
            ModifyProduct modprod = new ModifyProduct();
            foreach (DataGridViewRow row in dgProductMain.Rows)
            {
                if (row.Selected == true)
                {
                    Product product = (Product)row.DataBoundItem;
                    modprod.FillProd(product);
                    
                }
            }

            Hide();
           

            modprod.ShowDialog();





        }
 
        //Delete the selected Product.
        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgProductMain.Rows)
            {
                if(row.Selected == true)
                {
                    Product product = (Product)row.DataBoundItem;
                    int productID = product.ProductID;
                    Inventory.RemoveProduct(productID);

                }
            }

        }
        //Go to the add Part form.
        private void BtnPartAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Parts pScreen = new Parts();
            pScreen.ShowDialog();
            


        }
        //Go to the Modify Part form and load the selected row into the text boxes.
        private void BtnPartModify_Click(object sender, EventArgs e)
        {
            Hide();
            ModifyPart modpart = new ModifyPart();
            foreach (DataGridViewRow row in dgPartMain.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (row.Selected == true)
                {
                   modpart.FillBoxes(part);
                }
            }
            modpart.ShowDialog();

        }
           
        //Delete the selected Part.
        private void BtnPartDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgPartMain.Rows)
            {
                if (row.Selected == true)
                {
                    Part part = (Part)row.DataBoundItem;
                    int partID = part.PartID;
                    Inventory.DeletePart(partID);
                    
                }
            }

        }



        private void DgProductMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Part Search
        private void BtnPartSearch_Click(object sender, EventArgs e)
        {
            int value;
            bool isNumber = int.TryParse(tbPartSearch.Text, out value);
            if (isNumber)
            {

                foreach (DataGridViewRow row in dgPartMain.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == value)
                    {
                        row.Selected = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter PartId to Search");
                tbPartSearch.Clear();
            }
        }
        //Product Search
        private void BtnProductSearch_Click(object sender, EventArgs e)
        {
            int value;
            bool isNumber =  int.TryParse(tbProductSearch.Text, out value);
            if (isNumber)
            {


                foreach (DataGridViewRow row in dgProductMain.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    if (product.ProductID == value)
                    {
                        row.Selected = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter Product ID to Search");
                tbProductSearch.Clear();
            }

        }

        private void DgPartMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
