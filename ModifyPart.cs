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
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();

            //Validate type of data entered into Textboxes.
            tbModName.Mask = "L????????????";
            tbModInv.ValidatingType = typeof(int);
            tbModCost.ValidatingType = typeof(decimal);
            tbModMax.ValidatingType = typeof(int);
            tbModMin.ValidatingType = typeof(int);
            tbModName.MaskInputRejected += new MaskInputRejectedEventHandler(TbModName_MaskInputRejected);
            tbModInv.TypeValidationCompleted += new TypeValidationEventHandler(TbModInv_TypeValidationCompleted);
            tbModCost.TypeValidationCompleted += new TypeValidationEventHandler(tbModCost_TypeValidationCompleted);
            tbModMax.TypeValidationCompleted += new TypeValidationEventHandler(tbModMax_TypeValidationCompleted);
            tbModMin.TypeValidationCompleted += new TypeValidationEventHandler(tbModMin_TypeValidationCompleted);


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
        public void tbModCost_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Decimal Number.");
                e.Cancel = true;
                tbModCost.Clear();
            }
        }
        public void tbModMax_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbModMax.Clear();
            }
        }
        public void tbModMin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Please enter a valid Whole Number.");
                e.Cancel = true;
                tbModMin.Clear();
            }
        }

        //Helper to fill the part text boxes.
        public void FillBoxes (Part fillPart)
        {
            tbModID.Text = fillPart.PartID.ToString();
            tbModName.Text = fillPart.Name;
            tbModInv.Text = fillPart.InStock.ToString();
            tbModCost.Text = fillPart.Price.ToString();
            tbModMax.Text = fillPart.Max.ToString();
            tbModMin.Text = fillPart.Min.ToString();

            if(fillPart is Outsourced)
            {
                rbModOutsourced.Checked = true;
                tbModMachineID.Text = ((Outsourced)fillPart).CompanyName;
                lblMachineID.Text = "Company Name";
            }
            else
            {
                rbModInHouse.Checked = true;
                tbModMachineID.Text = ((InHouse)fillPart).MachineID.ToString();
                lblMachineID.Text = "Machine ID";
            }



        }

        //Change label based on radio button selection and validate that the text entered is of the correct type.  
        private void RbModInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModInHouse.Checked == true)
            {
                lblMachineID.Text = "Machine ID";
                tbModMachineID.Mask = "09999";
            }
            else
            {
                lblMachineID.Text = "Company Name";
                tbModMachineID.Mask = "L????????????????";

            }


        }
        //Change label based on radio button selection and validate that the text entered is of the correct type.  
        private void RbModOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModOutsourced.Checked == true)
            {
                lblMachineID.Text = "Company Name";
                tbModMachineID.Mask = "L????????????????";
            }
            else
            {
                lblMachineID.Text = "Machine ID";
                tbModMachineID.Mask = "09999";
            }

        }
        private void TbModID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TbModName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbModMachineID_TextChanged(object sender, EventArgs e)
        {

        }
        //Save changes and return to the Main screen.
        private void BtnModSave_Click(object sender, EventArgs e)
        {
            int partChangeId = Convert.ToInt32(tbModID.Text);


            if (rbModOutsourced.Checked == true)
            {

                Outsourced partChange = new Outsourced(int.Parse(tbModID.Text), tbModName.Text, int.Parse(tbModInv.Text), decimal.Parse(tbModCost.Text), int.Parse(tbModMin.Text), int.Parse(tbModMax.Text), tbModMachineID.Text);
                Inventory.UpdatePart(partChangeId, partChange);
            }
            else
            {
                InHouse partChange = new InHouse(int.Parse(tbModID.Text), tbModName.Text, int.Parse(tbModInv.Text), decimal.Parse(tbModCost.Text), int.Parse(tbModMin.Text), int.Parse(tbModMax.Text), int.Parse(tbModMachineID.Text));
                Inventory.UpdatePart(partChangeId, partChange);

            }


            Hide();
            MainScreen mainscreen = new MainScreen();
            mainscreen.ShowDialog();

        }

        //Cancel changes and return to the Main screen.
        private void BtnModCancel_Click(object sender, EventArgs e)
        {
 
            Hide();
            MainScreen mainscreen = new MainScreen();
            mainscreen.ShowDialog();
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
    }

}
