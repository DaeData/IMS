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
    public partial class Parts : Form
    {

        public Parts()
        {
            InitializeComponent();
            //Validate type of data entered into Textboxes.

            tbPartName.Mask = "L????????????";
            tbPartInvenory.ValidatingType = typeof(int);
            tbPartCost.ValidatingType = typeof(decimal);
            tbPartMax.ValidatingType = typeof(int);
            tbPartMin.ValidatingType = typeof(int);
            tbPartName.MaskInputRejected += new MaskInputRejectedEventHandler(TbPartName_MaskInputRejected);
            tbPartInvenory.TypeValidationCompleted += new TypeValidationEventHandler(TbPartInvenory_TypeValidationCompleted);
            tbPartCost.TypeValidationCompleted += new TypeValidationEventHandler(TbPartCost_TypeValidationCompleted);
            tbPartMax.TypeValidationCompleted += new TypeValidationEventHandler(TbPartMax_TypeValidationCompleted);
            tbPartMin.TypeValidationCompleted += new TypeValidationEventHandler(TbPartMin_TypeValidationCompleted);


        }
        //Validate that Max is greater than Min. If true, enable Save button.
        private void TbPartMin_Leave(object sender, EventArgs e)
        {
            if (int.Parse(tbPartMax.Text) < int.Parse(tbPartMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }

        }
        //Validate that Max is greater than Min. If true, enable Save button.
        private void TbPartMax_Leave(object sender, EventArgs e)
        {
            if (int.Parse(tbPartMax.Text) < int.Parse(tbPartMin.Text))
            {
                MessageBox.Show("Maximum Value must be greater than Minimum Value.");

            }
            else
            {
                btnSave.Enabled = true;
            }
        }




        //Change label based on radio button selection and validate that the text entered is of the correct type.  
        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        { //Parts Screen In-House Radio Button.
            if (rbInHouse.Checked == true)
            {
                lblPartMachineID.Text = "Machine ID";
                tbPartMachineId.Mask = "09999";
            }
            else
            {
                lblPartMachineID.Text = "Company Name";
                tbPartMachineId.Mask = "L????????????????";

            }


        }
        //Change label based on radio button selection and validate that the text entered is of the correct type.  
        private void RbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            //Parts Screen Outsourced Radio Button.
            if (rbOutsourced.Checked == true)
            {
                lblPartMachineID.Text = "Company Name";
                tbPartMachineId.Mask = "L????????????????";
            }
            else
            {
                lblPartMachineID.Text = "Machine ID";
                tbPartMachineId.Mask = "09999";
            }
        }

        //Cancel changes and return to the Main screen.
        private void PartCancel_Click(object sender, EventArgs e)
        {
            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
        }
        //Save data and return to the Main screen.
        private void PartSave_Click(object sender, EventArgs e)
        {
            //Add new Parts, Save and return to the main form.
            if (rbOutsourced.Checked == true)
            {
                
                Inventory.AddPart(new Outsourced((Inventory.partInc()), tbPartName.Text, int.Parse(tbPartInvenory.Text), decimal.Parse(tbPartCost.Text), int.Parse(tbPartMin.Text), int.Parse(tbPartMax.Text), tbPartMachineId.Text));

            }
            else if (rbInHouse.Checked == true)
            {

                Inventory.AddPart(new InHouse((Inventory.partInc()), tbPartName.Text, int.Parse(tbPartInvenory.Text), decimal.Parse(tbPartCost.Text), int.Parse(tbPartMin.Text), int.Parse(tbPartMax.Text), int.Parse(tbPartMachineId.Text)));
            }

            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
        }
        //Send user information on failed validation and clear the textbox.
        private void TbPartName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please Enter a Part Name.");
            tbPartName.Clear();


        }

        public void TbPartInvenory_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbPartInvenory.Clear();
            }
        }
        public void TbPartCost_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Decimal Number.");
                e.Cancel = true;
                tbPartCost.Clear();
            }
        }
        public void TbPartMax_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbPartMax.Clear();
            }
        }
        public void TbPartMin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbPartMin.Clear();
            }
        }


    }
}
