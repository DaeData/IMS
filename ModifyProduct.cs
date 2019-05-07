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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();

            dgModProdAll.DataSource = Inventory.AllParts;


            dgModProdAssoc.DataSource = Product.AssociatedParts;
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

        }

        private void BtnModDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnModSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnModCancel_Click(object sender, EventArgs e)
        {

        }

        private void DgModProdAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgModProdAssoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
