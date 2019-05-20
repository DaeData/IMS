using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    public partial class ModifyProduct : Form
    {
        BindingSource partToProd = new BindingSource();
        BindingList<Part> associatedParts = new BindingList<Part>();

        //MainScreen Main = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProduct()
        {
            InitializeComponent();
            ModifyProduct_Load();



        }






        public void ModifyProduct_Load()
        {

            dgModProdAll.DataSource = Inventory.AllParts;

            partToProd.DataSource = associatedParts;
            dgModProdAssoc.DataSource = partToProd;

            dgModProdAssoc.Columns["PartID"].HeaderText = "Part ID";
            dgModProdAssoc.Columns["Name"].HeaderText = "Name";
            dgModProdAssoc.Columns["InStock"].HeaderText = "Inventory";
            dgModProdAssoc.Columns["Price"].HeaderText = "Price";
            dgModProdAssoc.Columns["Min"].HeaderText = "Min";
            dgModProdAssoc.Columns["Max"].HeaderText = "Max";




        }




        internal void FillProd(Product prodPart)

        {
            tbModId.Text = prodPart.ProductID.ToString();
            tbModName.Text = prodPart.Name;
            tbModInv.Text = prodPart.InStock.ToString();
            tbModPrice.Text = prodPart.Price.ToString();
            tbModMax.Text = prodPart.Max.ToString();
            tbModMin.Text = prodPart.Min.ToString();


        }



        private void TbModName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnModSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnModAdd_Click(object sender, EventArgs e)
        {
            if (dgModProdAll.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                Part addPart = (Part)dgModProdAll.CurrentRow.DataBoundItem;

                associatedParts.Add(addPart);


            }

        }

        private void BtnModDelete_Click(object sender, EventArgs e)
        {
            int delPart = dgModProdAssoc.CurrentRow.Index;
            Product.RemoveAssociatedPart(delPart);


        }

        private void BtnModSave_Click(object sender, EventArgs e)

        {

            int changeProd = int.Parse(tbModId.Text);
            Product prodChange = new Product(changeProd, tbModName.Text, int.Parse(tbModInv.Text), decimal.Parse(tbModPrice.Text), int.Parse(tbModMin.Text), int.Parse(tbModMax.Text));

            Inventory.UpdateProduct(changeProd, prodChange);

            Hide();
            MainScreen main = new MainScreen();
            main.Show();

        }


        private void BtnModCancel_Click(object sender, EventArgs e)
        {

            Close();
            MainScreen mainscreen = new MainScreen();
            mainscreen.ShowDialog();

        }

        private void DgModProdAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgModProdAssoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
