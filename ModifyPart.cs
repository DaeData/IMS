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

        }

        private void BtnModCancel_Click(object sender, EventArgs e)
        {
            Hide();
            MainScreen mainscreen = new MainScreen();
            mainscreen.Show();
        }
    }
}
