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
           
            

        }
        

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
            }
            else
            {
                rbModInHouse.Checked = true;
                tbModMachineID.Text = ((InHouse)fillPart).MachineID.ToString();
            }



        }

      


        private void RbModInHouse_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void RbModOutsourced_CheckedChanged(object sender, EventArgs e)
        {


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

        private void BtnModCancel_Click(object sender, EventArgs e)
        {
 
            Hide();
            MainScreen mainscreen = new MainScreen();
            mainscreen.ShowDialog();
        }
    }
}
