namespace Inventory_Management_System_KKellerman
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblModTitle = new System.Windows.Forms.Label();
            this.dgModProdAll = new System.Windows.Forms.DataGridView();
            this.dgModProdAssoc = new System.Windows.Forms.DataGridView();
            this.lblModId = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblModInv = new System.Windows.Forms.Label();
            this.lblModPrice = new System.Windows.Forms.Label();
            this.lblModMax = new System.Windows.Forms.Label();
            this.lblModMin = new System.Windows.Forms.Label();
            this.tbModId = new System.Windows.Forms.TextBox();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.tbModInv = new System.Windows.Forms.TextBox();
            this.tbModPrice = new System.Windows.Forms.TextBox();
            this.tbModMax = new System.Windows.Forms.TextBox();
            this.tbModMin = new System.Windows.Forms.TextBox();
            this.lblCandPart = new System.Windows.Forms.Label();
            this.lblAssocParts = new System.Windows.Forms.Label();
            this.tbModSearch = new System.Windows.Forms.TextBox();
            this.btnModSearch = new System.Windows.Forms.Button();
            this.btnModAdd = new System.Windows.Forms.Button();
            this.btnModDelete = new System.Windows.Forms.Button();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.btnModSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgModProdAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModProdAssoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModTitle
            // 
            this.lblModTitle.AutoSize = true;
            this.lblModTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModTitle.Location = new System.Drawing.Point(13, 13);
            this.lblModTitle.Name = "lblModTitle";
            this.lblModTitle.Size = new System.Drawing.Size(117, 21);
            this.lblModTitle.TabIndex = 0;
            this.lblModTitle.Text = "Modify Product";
            // 
            // dgModProdAll
            // 
            this.dgModProdAll.AllowUserToAddRows = false;
            this.dgModProdAll.AllowUserToDeleteRows = false;
            this.dgModProdAll.AllowUserToResizeColumns = false;
            this.dgModProdAll.AllowUserToResizeRows = false;
            this.dgModProdAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgModProdAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgModProdAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgModProdAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgModProdAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgModProdAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgModProdAll.Location = new System.Drawing.Point(358, 73);
            this.dgModProdAll.MultiSelect = false;
            this.dgModProdAll.Name = "dgModProdAll";
            this.dgModProdAll.ReadOnly = true;
            this.dgModProdAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgModProdAll.RowHeadersVisible = false;
            this.dgModProdAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgModProdAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgModProdAll.Size = new System.Drawing.Size(637, 150);
            this.dgModProdAll.TabIndex = 1;
            this.dgModProdAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgModProdAll_CellContentClick);
            // 
            // dgModProdAssoc
            // 
            this.dgModProdAssoc.AllowUserToAddRows = false;
            this.dgModProdAssoc.AllowUserToDeleteRows = false;
            this.dgModProdAssoc.AllowUserToResizeColumns = false;
            this.dgModProdAssoc.AllowUserToResizeRows = false;
            this.dgModProdAssoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgModProdAssoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgModProdAssoc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgModProdAssoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgModProdAssoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgModProdAssoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgModProdAssoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgModProdAssoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgModProdAssoc.Location = new System.Drawing.Point(358, 323);
            this.dgModProdAssoc.MultiSelect = false;
            this.dgModProdAssoc.Name = "dgModProdAssoc";
            this.dgModProdAssoc.ReadOnly = true;
            this.dgModProdAssoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgModProdAssoc.RowHeadersVisible = false;
            this.dgModProdAssoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgModProdAssoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgModProdAssoc.Size = new System.Drawing.Size(637, 150);
            this.dgModProdAssoc.StandardTab = true;
            this.dgModProdAssoc.TabIndex = 2;
            this.dgModProdAssoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgModProdAssoc_CellContentClick);
            // 
            // lblModId
            // 
            this.lblModId.AutoSize = true;
            this.lblModId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModId.Location = new System.Drawing.Point(27, 92);
            this.lblModId.Name = "lblModId";
            this.lblModId.Size = new System.Drawing.Size(20, 17);
            this.lblModId.TabIndex = 3;
            this.lblModId.Text = "ID";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModName.Location = new System.Drawing.Point(27, 137);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(43, 17);
            this.lblModName.TabIndex = 4;
            this.lblModName.Text = "Name";
            // 
            // lblModInv
            // 
            this.lblModInv.AutoSize = true;
            this.lblModInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModInv.Location = new System.Drawing.Point(27, 174);
            this.lblModInv.Name = "lblModInv";
            this.lblModInv.Size = new System.Drawing.Size(61, 17);
            this.lblModInv.TabIndex = 5;
            this.lblModInv.Text = "Inventory";
            // 
            // lblModPrice
            // 
            this.lblModPrice.AutoSize = true;
            this.lblModPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModPrice.Location = new System.Drawing.Point(27, 219);
            this.lblModPrice.Name = "lblModPrice";
            this.lblModPrice.Size = new System.Drawing.Size(36, 17);
            this.lblModPrice.TabIndex = 6;
            this.lblModPrice.Text = "Price";
            // 
            // lblModMax
            // 
            this.lblModMax.AutoSize = true;
            this.lblModMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMax.Location = new System.Drawing.Point(27, 264);
            this.lblModMax.Name = "lblModMax";
            this.lblModMax.Size = new System.Drawing.Size(33, 17);
            this.lblModMax.TabIndex = 7;
            this.lblModMax.Text = "Max";
            // 
            // lblModMin
            // 
            this.lblModMin.AutoSize = true;
            this.lblModMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMin.Location = new System.Drawing.Point(191, 265);
            this.lblModMin.Name = "lblModMin";
            this.lblModMin.Size = new System.Drawing.Size(30, 17);
            this.lblModMin.TabIndex = 8;
            this.lblModMin.Text = "Min";
            // 
            // tbModId
            // 
            this.tbModId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModId.Location = new System.Drawing.Point(90, 89);
            this.tbModId.Name = "tbModId";
            this.tbModId.ReadOnly = true;
            this.tbModId.Size = new System.Drawing.Size(100, 25);
            this.tbModId.TabIndex = 9;
            this.tbModId.WordWrap = false;
            // 
            // tbModName
            // 
            this.tbModName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModName.Location = new System.Drawing.Point(90, 130);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(100, 25);
            this.tbModName.TabIndex = 10;
            this.tbModName.WordWrap = false;
            this.tbModName.TextChanged += new System.EventHandler(this.TbModName_TextChanged);
            // 
            // tbModInv
            // 
            this.tbModInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModInv.Location = new System.Drawing.Point(90, 171);
            this.tbModInv.Name = "tbModInv";
            this.tbModInv.Size = new System.Drawing.Size(100, 25);
            this.tbModInv.TabIndex = 11;
            this.tbModInv.WordWrap = false;
            this.tbModInv.TextChanged += new System.EventHandler(this.TbModInv_TextChanged);
            // 
            // tbModPrice
            // 
            this.tbModPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModPrice.Location = new System.Drawing.Point(90, 212);
            this.tbModPrice.Name = "tbModPrice";
            this.tbModPrice.Size = new System.Drawing.Size(100, 25);
            this.tbModPrice.TabIndex = 12;
            this.tbModPrice.WordWrap = false;
            this.tbModPrice.TextChanged += new System.EventHandler(this.TbModPrice_TextChanged);
            // 
            // tbModMax
            // 
            this.tbModMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModMax.Location = new System.Drawing.Point(90, 261);
            this.tbModMax.Name = "tbModMax";
            this.tbModMax.Size = new System.Drawing.Size(69, 25);
            this.tbModMax.TabIndex = 13;
            this.tbModMax.WordWrap = false;
            this.tbModMax.TextChanged += new System.EventHandler(this.TbModMax_TextChanged);
            // 
            // tbModMin
            // 
            this.tbModMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModMin.Location = new System.Drawing.Point(247, 261);
            this.tbModMin.Name = "tbModMin";
            this.tbModMin.Size = new System.Drawing.Size(69, 25);
            this.tbModMin.TabIndex = 14;
            this.tbModMin.WordWrap = false;
            this.tbModMin.TextChanged += new System.EventHandler(this.TbModMin_TextChanged);
            // 
            // lblCandPart
            // 
            this.lblCandPart.AutoSize = true;
            this.lblCandPart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandPart.Location = new System.Drawing.Point(355, 53);
            this.lblCandPart.Name = "lblCandPart";
            this.lblCandPart.Size = new System.Drawing.Size(118, 17);
            this.lblCandPart.TabIndex = 15;
            this.lblCandPart.Text = "All Candidate Parts";
            // 
            // lblAssocParts
            // 
            this.lblAssocParts.AutoSize = true;
            this.lblAssocParts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocParts.Location = new System.Drawing.Point(355, 303);
            this.lblAssocParts.Name = "lblAssocParts";
            this.lblAssocParts.Size = new System.Drawing.Size(204, 17);
            this.lblAssocParts.TabIndex = 16;
            this.lblAssocParts.Text = "Parts Associated with this Product";
            // 
            // tbModSearch
            // 
            this.tbModSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModSearch.Location = new System.Drawing.Point(813, 42);
            this.tbModSearch.Name = "tbModSearch";
            this.tbModSearch.Size = new System.Drawing.Size(181, 25);
            this.tbModSearch.TabIndex = 18;
            this.tbModSearch.WordWrap = false;
            this.tbModSearch.TextChanged += new System.EventHandler(this.TbModSearch_TextChanged);
            // 
            // btnModSearch
            // 
            this.btnModSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModSearch.Location = new System.Drawing.Point(732, 43);
            this.btnModSearch.Name = "btnModSearch";
            this.btnModSearch.Size = new System.Drawing.Size(75, 23);
            this.btnModSearch.TabIndex = 19;
            this.btnModSearch.Text = "Search";
            this.btnModSearch.UseVisualStyleBackColor = true;
            this.btnModSearch.Click += new System.EventHandler(this.BtnModSearch_Click);
            // 
            // btnModAdd
            // 
            this.btnModAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAdd.Location = new System.Drawing.Point(919, 243);
            this.btnModAdd.Name = "btnModAdd";
            this.btnModAdd.Size = new System.Drawing.Size(75, 23);
            this.btnModAdd.TabIndex = 20;
            this.btnModAdd.Text = "Add";
            this.btnModAdd.UseVisualStyleBackColor = true;
            this.btnModAdd.Click += new System.EventHandler(this.BtnModAdd_Click);
            // 
            // btnModDelete
            // 
            this.btnModDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModDelete.Location = new System.Drawing.Point(920, 479);
            this.btnModDelete.Name = "btnModDelete";
            this.btnModDelete.Size = new System.Drawing.Size(75, 23);
            this.btnModDelete.TabIndex = 21;
            this.btnModDelete.Text = "Delete";
            this.btnModDelete.UseVisualStyleBackColor = true;
            this.btnModDelete.Click += new System.EventHandler(this.BtnModDelete_Click);
            // 
            // btnModCancel
            // 
            this.btnModCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCancel.Location = new System.Drawing.Point(919, 520);
            this.btnModCancel.Name = "btnModCancel";
            this.btnModCancel.Size = new System.Drawing.Size(75, 23);
            this.btnModCancel.TabIndex = 22;
            this.btnModCancel.Text = "Cancel";
            this.btnModCancel.UseVisualStyleBackColor = true;
            this.btnModCancel.Click += new System.EventHandler(this.BtnModCancel_Click);
            // 
            // btnModSave
            // 
            this.btnModSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModSave.Location = new System.Drawing.Point(829, 520);
            this.btnModSave.Name = "btnModSave";
            this.btnModSave.Size = new System.Drawing.Size(75, 23);
            this.btnModSave.TabIndex = 23;
            this.btnModSave.Text = "Save";
            this.btnModSave.UseVisualStyleBackColor = true;
            this.btnModSave.Click += new System.EventHandler(this.BtnModSave_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 549);
            this.Controls.Add(this.btnModSave);
            this.Controls.Add(this.btnModCancel);
            this.Controls.Add(this.btnModDelete);
            this.Controls.Add(this.btnModAdd);
            this.Controls.Add(this.btnModSearch);
            this.Controls.Add(this.tbModSearch);
            this.Controls.Add(this.lblAssocParts);
            this.Controls.Add(this.lblCandPart);
            this.Controls.Add(this.tbModMin);
            this.Controls.Add(this.tbModMax);
            this.Controls.Add(this.tbModPrice);
            this.Controls.Add(this.tbModInv);
            this.Controls.Add(this.tbModName);
            this.Controls.Add(this.tbModId);
            this.Controls.Add(this.lblModMin);
            this.Controls.Add(this.lblModMax);
            this.Controls.Add(this.lblModPrice);
            this.Controls.Add(this.lblModInv);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblModId);
            this.Controls.Add(this.dgModProdAssoc);
            this.Controls.Add(this.dgModProdAll);
            this.Controls.Add(this.lblModTitle);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgModProdAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModProdAssoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModTitle;
        private System.Windows.Forms.Label lblModId;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModInv;
        private System.Windows.Forms.Label lblModPrice;
        private System.Windows.Forms.Label lblModMax;
        private System.Windows.Forms.Label lblModMin;
        private System.Windows.Forms.TextBox tbModId;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.TextBox tbModInv;
        private System.Windows.Forms.TextBox tbModPrice;
        private System.Windows.Forms.TextBox tbModMax;
        private System.Windows.Forms.TextBox tbModMin;
        private System.Windows.Forms.Label lblCandPart;
        private System.Windows.Forms.Label lblAssocParts;
        private System.Windows.Forms.TextBox tbModSearch;
        private System.Windows.Forms.Button btnModSearch;
        private System.Windows.Forms.Button btnModAdd;
        private System.Windows.Forms.Button btnModDelete;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.Button btnModSave;
        public System.Windows.Forms.DataGridView dgModProdAll;
        public System.Windows.Forms.DataGridView dgModProdAssoc;
    }
}