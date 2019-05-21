using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    public partial class ModifyProduct : Form
    {

        BindingList<Part> partProd = new BindingList<Part>();
        //BindingSource bindingSource = new BindingSource();



       

        public ModifyProduct()
        {
            InitializeComponent();
            ModifyProduct_Load();
           





        }

        //public void Part_Load()
        //{
        //    int prodId = int.Parse(tbModId.Text);



        //}



        public void ModifyProduct_Load()
        {

            dgModProdAll.DataSource = Inventory.AllParts;
            //bindingSource.DataSource = partProd;
            dgModProdAssoc.DataSource = partProd;



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
            int value = int.Parse(tbModSearch.Text);
            foreach (DataGridViewRow row in dgModProdAll.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == value)
                {
                    row.Selected = true;
                }
            }
        }

        private void BtnModAdd_Click(object sender, EventArgs e)
        {
            
            Part part = (Part)dgModProdAll.CurrentRow.DataBoundItem;
            partProd.Add(part);

           
        }

        private void BtnModDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgModProdAll.Rows)
            {
                if (row.Selected == true)
                {
                    Part part = (Part)row.DataBoundItem;
                    int partID = part.PartID;
                    partProd.Remove(part);
                    Product.RemoveAssociatedPart(partID);



                }

            }


        }

        private void BtnModSave_Click(object sender, EventArgs e)

        {

            int changeProd = int.Parse(tbModId.Text);
            Product prodChange = new Product(changeProd, tbModName.Text, int.Parse(tbModInv.Text), decimal.Parse(tbModPrice.Text), int.Parse(tbModMin.Text), int.Parse(tbModMax.Text));

            Inventory.UpdateProduct(changeProd, prodChange);


            foreach(Part part in partProd)
            {
                prodChange.AddAssociatedPart(part);
            }

            Hide();
            MainScreen main = new MainScreen();
            main.ShowDialog();

        }


        private void BtnModCancel_Click(object sender, EventArgs e)
        {

            Hide();
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
