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

        }



        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        { //Parts Screen In-House Radio Button.
            if (rbInHouse.Checked == true)
            {
                lblPartMachineID.Text = "Machine ID";
            }
            else
            {
                lblPartMachineID.Text = "Company Name";
                
            }

            
        }

        private void RbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            //Parts Screen Outsourced Radio Button.
            if(rbOutsourced.Checked == true)
            {
                lblPartMachineID.Text = "Company Name";

            }
            else
            {
                lblPartMachineID.Text = "Machine ID";
                
            }
        }





        private void PartCancel_Click(object sender, EventArgs e)
        {
            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void PartSave_Click(object sender, EventArgs e)
        {
            if (rbOutsourced.Checked == true)
            {
                Inventory.AddPart(new Outsourced((Inventory.AllParts.Count + 1), tbPartName.Text, int.Parse(tbPartInvenory.Text), decimal.Parse(tbPartCost.Text), int.Parse(tbPartMin.Text), int.Parse(tbPartMax.Text), tbPartMachineId.Text));
               
            }
            else if (rbInHouse.Checked == true)
            {
                Inventory.AddPart(new InHouse((Inventory.AllParts.Count + 1), tbPartName.Text, int.Parse(tbPartInvenory.Text), decimal.Parse(tbPartCost.Text), int.Parse(tbPartMin.Text), int.Parse(tbPartMax.Text), int.Parse(tbPartMachineId.Text)));
            }
            //Inventory.AllParts.ResetBindings();
            
            Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }
    }
}
