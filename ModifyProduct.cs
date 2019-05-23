using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System_KKellerman
{
    public partial class ModifyProduct : Form
    {

        BindingList<Part> partProd = new BindingList<Part>();
        BindingSource bindingSource = new BindingSource();



       

        public ModifyProduct()
        {
            InitializeComponent();
            ModifyProduct_Load();

            //Validate type of data entered into Textboxes.
            tbModName.Mask = "L????????????";
            tbModInv.ValidatingType = typeof(int);
            tbModPrice.ValidatingType = typeof(decimal);
            tbModMax.ValidatingType = typeof(int);
            tbModMin.ValidatingType = typeof(int);
            tbModName.MaskInputRejected += new MaskInputRejectedEventHandler(TbModName_MaskInputRejected);
            tbModInv.TypeValidationCompleted += new TypeValidationEventHandler(TbModInv_TypeValidationCompleted);
            tbModPrice.TypeValidationCompleted += new TypeValidationEventHandler(TbModCost_TypeValidationCompleted);
            tbModMax.TypeValidationCompleted += new TypeValidationEventHandler(TbModMax_TypeValidationCompleted);
            tbModMin.TypeValidationCompleted += new TypeValidationEventHandler(TbModMin_TypeValidationCompleted);

        }

        //Send user information on failed validation and clear the textbox.
        private void TbModName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please Enter a Part Name.");
            tbModName.Clear();


        }

        public void TbModInv_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbModInv.Clear();
            }
        }
        public void TbModCost_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Decimal Number.");
                e.Cancel = true;
                tbModPrice.Clear();
            }
        }
        public void TbModMax_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbModMax.Clear();
            }
        }
        public void TbModMin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbModMin.Clear();
            }
        }



        //Define how the data will be bound and format the data grids.
        public void ModifyProduct_Load()
        {

            dgModProdAll.DataSource = Inventory.AllParts;
            bindingSource.DataSource = partProd;
            dgModProdAssoc.DataSource = bindingSource;



            dgModProdAssoc.Columns["PartID"].HeaderText = "Part ID";
            dgModProdAssoc.Columns["Name"].HeaderText = "Name";
            dgModProdAssoc.Columns["InStock"].HeaderText = "Inventory";
            dgModProdAssoc.Columns["Price"].HeaderText = "Price";
            dgModProdAssoc.Columns["Min"].HeaderText = "Min";
            dgModProdAssoc.Columns["Max"].HeaderText = "Max";

            

        }

        //Validate that Max is greater than Min. If true, enable Save button.
        private void TbModMax_Leave(object sender, EventArgs e)
        {
            if (int.Parse(tbModMax.Text) <= int.Parse(tbModMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        //Validate that Max is greater than Min. If true, enable Save button.
        private void TbModMin_Leave(object sender, EventArgs e)
        {
            if (int.Parse(tbModMax.Text) <= int.Parse(tbModMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }
        }





    //Helper to fill the product text boxes.
    internal void FillProd(Product prodPart)

        {
            tbModId.Text = prodPart.ProductID.ToString();
            tbModName.Text = prodPart.Name;
            tbModInv.Text = prodPart.InStock.ToString();
            tbModPrice.Text = prodPart.Price.ToString();
            tbModMax.Text = prodPart.Max.ToString();
            tbModMin.Text = prodPart.Min.ToString();
            
            foreach(Part part in Product.AssociatedParts)
            {
                int prodID = int.Parse(tbModId.Text);
                Part partAdd = Product.LookupAssociatedPart(prodID);
                if (partAdd !=null)
                {
                    
                    bindingSource.Add(part);

                }

               
                
            }
            


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
        //Search for parts.
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
        //Associate a part with a product.
        private void BtnModAdd_Click(object sender, EventArgs e)
        {
            
            
           
            foreach(DataGridViewRow row in dgModProdAll.Rows)
            {
                if(row.Selected == true)
                {
                    Part part = (Part)dgModProdAll.CurrentRow.DataBoundItem;
                    bindingSource.Add(part);
                }
            }
            

           
        }
        //Remove part Association with a product.
        private void BtnModDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgModProdAll.Rows)
            {
                if (row.Selected == true)
                {
                    Part part = (Part)dgModProdAssoc.CurrentRow.DataBoundItem;
                    bindingSource.Remove(part);
                    Product.RemoveAssociatedPart(part.PartID);
                    

                }

            }


        }
        //Save Product and return to the Main form.
        private void BtnModSave_Click(object sender, EventArgs e)

        {

            int changeProd = int.Parse(tbModId.Text);
            Product prodChange = new Product(changeProd, tbModName.Text, int.Parse(tbModInv.Text), decimal.Parse(tbModPrice.Text), int.Parse(tbModMin.Text), int.Parse(tbModMax.Text));

            Inventory.UpdateProduct(changeProd, prodChange);


            foreach(Part part in partProd)
            {
                
                Product.AddAssociatedPart(part);
            }
            
            Hide();
            MainScreen main = new MainScreen();
            main.ShowDialog();

        }

        //Cancel Modifying a product and return to the Main Form.
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
