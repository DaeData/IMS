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
        private BindingSource partsGrid = new BindingSource();
        public Products()
        {
            
            InitializeComponent();
            Prod_Load();

            //Validate type of data entered into Textboxes.
            tbProductName.Mask = "L????????????";
            tbProductInv.ValidatingType = typeof(int);
            tbProductPrice.ValidatingType = typeof(decimal);
            tbProductMax.ValidatingType = typeof(int);
            tbProductMin.ValidatingType = typeof(int);
            tbProductName.MaskInputRejected += new MaskInputRejectedEventHandler(TbProductName_MaskInputRejected);
            tbProductInv.TypeValidationCompleted += new TypeValidationEventHandler(TbProductInv_TypeValidationCompleted);
            tbProductPrice.TypeValidationCompleted += new TypeValidationEventHandler(TbProductPrice_TypeValidationCompleted);
            tbProductMax.TypeValidationCompleted += new TypeValidationEventHandler(TbProductMax_TypeValidationCompleted);
            tbProductMin.TypeValidationCompleted += new TypeValidationEventHandler(TbProductMin_TypeValidationCompleted);
            
        }

        private void TbProductName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
            MessageBox.Show("Please Enter a Part Name.");
            tbProductName.Clear();


        }

        public void TbProductInv_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbProductInv.Clear();
            }
        }
        public void TbProductPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Decimal Number.");
                e.Cancel = true;
                tbProductPrice.Clear();
            }
        }
        public void TbProductMax_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbProductMax.Clear();
            }
        }
        public void TbProductMin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbProductMin.Clear();
            }
        }

        public void Prod_Load()
        {

            dgAllParts.DataSource = Inventory.AllParts;

            partsGrid.DataSource = partsAssoc;
            dgAssocProd.DataSource = partsGrid;

            dgAssocProd.Columns["PartID"].HeaderText = "Part ID";
            dgAssocProd.Columns["Name"].HeaderText = "Name";
            dgAssocProd.Columns["InStock"].HeaderText = "Inventory";
            dgAssocProd.Columns["Price"].HeaderText = "Price";
            dgAssocProd.Columns["Min"].HeaderText = "Min";
            dgAssocProd.Columns["Max"].HeaderText = "Max";

        }
        public  bool CheckStuff()
        {
            if (Controls.OfType<TextBox>().Any(tbox => string.IsNullOrEmpty(tbox.Text)))
            {
                MessageBox.Show("Please fill all fields");
                return true;
            }
            else
            {
                return false;
            }

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
            int value;
            bool isNumber = int.TryParse(tbAllSearch.Text, out value);
            if (isNumber)
            {

                foreach (DataGridViewRow row in dgAllParts.Rows)
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
                tbAllSearch.Clear();
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
        //Save the New Product.
        private void BtnProdSave_Click(object sender, EventArgs e)
        {
          if(int.Parse(tbProductMax.Text) > int.Parse(tbProductMin.Text))
            {
                Product products = new Product(Inventory.prodInc(), tbProductName.Text, int.Parse(tbProductInv.Text), decimal.Parse(tbProductPrice.Text), int.Parse(tbProductMin.Text), int.Parse(tbProductMax.Text));
                Inventory.AddProduct(products);
            }
          else
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");
            }

            
           
            foreach(Part part in partsAssoc)
            {
                Product.AddAssociatedPart(part);
            }

            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }


        //Validate that Max is greater than Min.If true, enable Save button.
        private void TbProductMax_Leave(object sender, EventArgs e)
        {
            if (!(CheckStuff()))
            {
                return;
            }
            else if (int.Parse(tbProductMax.Text) <= int.Parse(tbProductMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        //Validate that Max is greater than Min. If true, enable Save button.
        private void TbProductMin_Leave(object sender, EventArgs e)
        {
            if (int.Parse(tbProductMax.Text) < int.Parse(tbProductMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }
        }



    }
}
