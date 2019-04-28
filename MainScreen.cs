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
        public MainScreen()
        {
            InitializeComponent();
            
            dgPartMain.DataSource = Inventory.AllParts;
            
            dgPartMain.Columns["PartID"].HeaderText = "Part ID";
            dgPartMain.Columns["Name"].HeaderText = "Name";
            dgPartMain.Columns["InStock"].HeaderText = "Inventory";
            dgPartMain.Columns["Price"].HeaderText = "Price";
            dgPartMain.Columns["Min"].HeaderText = "Min";
            dgPartMain.Columns["Max"].HeaderText = "Max";


            dgProductMain.DataSource = Inventory.Products;

            dgProductMain.Columns["ProductID"].HeaderText = "Product ID";
            dgProductMain.Columns["Name"].HeaderText = "Name";
            dgProductMain.Columns["InStock"].HeaderText = "Inventory";
            dgProductMain.Columns["Price"].HeaderText = "Price";
            dgProductMain.Columns["Min"].HeaderText = "Min";
            dgProductMain.Columns["Max"].HeaderText = "Max";
        }


      


        private void Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }



        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Products prodForm = new Products();
            prodForm.ShowDialog();
            

        }

        private void BtnProductModify_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnPartAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Parts pScreen = new Parts();
            pScreen.ShowDialog();
           
            
           
        }

        private void BtnPartModify_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnPartDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void DgPartMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgProductMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
