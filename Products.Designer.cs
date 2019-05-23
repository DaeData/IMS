namespace Inventory_Management_System_KKellerman
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblProdMin = new System.Windows.Forms.Label();
            this.lblProdMax = new System.Windows.Forms.Label();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdInventory = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.MaskedTextBox();
            this.tbProductName = new System.Windows.Forms.MaskedTextBox();
            this.tbProductInv = new System.Windows.Forms.MaskedTextBox();
            this.tbProductPrice = new System.Windows.Forms.MaskedTextBox();
            this.tbProductMax = new System.Windows.Forms.MaskedTextBox();
            this.tbProductMin = new System.Windows.Forms.MaskedTextBox();
            this.dgAllParts = new System.Windows.Forms.DataGridView();
            this.lblAllCandParts = new System.Windows.Forms.Label();
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.tbAllSearch = new System.Windows.Forms.MaskedTextBox();
            this.dgAssocProd = new System.Windows.Forms.DataGridView();
            this.lblPartAssocProd = new System.Windows.Forms.Label();
            this.btnCandidateAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAssocPartDel = new System.Windows.Forms.Button();
            this.btnProductCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssocProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(16, 17);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(117, 25);
            this.lblProd.TabIndex = 0;
            this.lblProd.Text = "Add Product";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdId.Location = new System.Drawing.Point(64, 171);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(25, 21);
            this.lblProdId.TabIndex = 1;
            this.lblProdId.Text = "ID";
            // 
            // lblProdMin
            // 
            this.lblProdMin.AutoSize = true;
            this.lblProdMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMin.Location = new System.Drawing.Point(211, 345);
            this.lblProdMin.Name = "lblProdMin";
            this.lblProdMin.Size = new System.Drawing.Size(37, 21);
            this.lblProdMin.TabIndex = 2;
            this.lblProdMin.Text = "Min";
            // 
            // lblProdMax
            // 
            this.lblProdMax.AutoSize = true;
            this.lblProdMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMax.Location = new System.Drawing.Point(50, 345);
            this.lblProdMax.Name = "lblProdMax";
            this.lblProdMax.Size = new System.Drawing.Size(39, 21);
            this.lblProdMax.TabIndex = 3;
            this.lblProdMax.Text = "Max";
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.Location = new System.Drawing.Point(45, 299);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(44, 21);
            this.lblProdPrice.TabIndex = 4;
            this.lblProdPrice.Text = "Price";
            // 
            // lblProdInventory
            // 
            this.lblProdInventory.AutoSize = true;
            this.lblProdInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdInventory.Location = new System.Drawing.Point(18, 260);
            this.lblProdInventory.Name = "lblProdInventory";
            this.lblProdInventory.Size = new System.Drawing.Size(76, 21);
            this.lblProdInventory.TabIndex = 5;
            this.lblProdInventory.Text = "Inventory";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(39, 217);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(52, 21);
            this.lblProdName.TabIndex = 6;
            this.lblProdName.Text = "Name";
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(97, 171);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(100, 25);
            this.tbProductID.TabIndex = 7;
            // 
            // tbProductName
            // 
            this.tbProductName.HidePromptOnLeave = true;
            this.tbProductName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbProductName.Location = new System.Drawing.Point(97, 213);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ResetOnSpace = false;
            this.tbProductName.Size = new System.Drawing.Size(100, 25);
            this.tbProductName.TabIndex = 8;
            this.tbProductName.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbProductInv
            // 
            this.tbProductInv.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbProductInv.HidePromptOnLeave = true;
            this.tbProductInv.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbProductInv.Location = new System.Drawing.Point(97, 256);
            this.tbProductInv.Name = "tbProductInv";
            this.tbProductInv.ResetOnSpace = false;
            this.tbProductInv.Size = new System.Drawing.Size(100, 25);
            this.tbProductInv.TabIndex = 9;
            this.tbProductInv.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(97, 295);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(100, 25);
            this.tbProductPrice.TabIndex = 10;
            // 
            // tbProductMax
            // 
            this.tbProductMax.Location = new System.Drawing.Point(100, 341);
            this.tbProductMax.Name = "tbProductMax";
            this.tbProductMax.Size = new System.Drawing.Size(100, 25);
            this.tbProductMax.TabIndex = 11;
            // 
            // tbProductMin
            // 
            this.tbProductMin.Location = new System.Drawing.Point(259, 341);
            this.tbProductMin.Name = "tbProductMin";
            this.tbProductMin.Size = new System.Drawing.Size(100, 25);
            this.tbProductMin.TabIndex = 12;
            // 
            // dgAllParts
            // 
            this.dgAllParts.AllowUserToAddRows = false;
            this.dgAllParts.AllowUserToDeleteRows = false;
            this.dgAllParts.AllowUserToResizeColumns = false;
            this.dgAllParts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAllParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAllParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllParts.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgAllParts.Location = new System.Drawing.Point(430, 100);
            this.dgAllParts.Margin = new System.Windows.Forms.Padding(0);
            this.dgAllParts.MultiSelect = false;
            this.dgAllParts.Name = "dgAllParts";
            this.dgAllParts.ReadOnly = true;
            this.dgAllParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAllParts.RowHeadersVisible = false;
            this.dgAllParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgAllParts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgAllParts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.RowTemplate.ReadOnly = true;
            this.dgAllParts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllParts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAllParts.Size = new System.Drawing.Size(566, 150);
            this.dgAllParts.TabIndex = 13;
            this.dgAllParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAllParts_CellContentClick);
            // 
            // lblAllCandParts
            // 
            this.lblAllCandParts.AutoSize = true;
            this.lblAllCandParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCandParts.Location = new System.Drawing.Point(426, 76);
            this.lblAllCandParts.Name = "lblAllCandParts";
            this.lblAllCandParts.Size = new System.Drawing.Size(140, 21);
            this.lblAllCandParts.TabIndex = 14;
            this.lblAllCandParts.Text = "All Candidate Parts";
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Location = new System.Drawing.Point(703, 65);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAllSearch.TabIndex = 15;
            this.btnAllSearch.Text = "Search";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.BtnAllSearch_Click);
            // 
            // tbAllSearch
            // 
            this.tbAllSearch.Location = new System.Drawing.Point(793, 65);
            this.tbAllSearch.Name = "tbAllSearch";
            this.tbAllSearch.Size = new System.Drawing.Size(203, 25);
            this.tbAllSearch.TabIndex = 16;
            // 
            // dgAssocProd
            // 
            this.dgAssocProd.AllowUserToAddRows = false;
            this.dgAssocProd.AllowUserToResizeColumns = false;
            this.dgAssocProd.AllowUserToResizeRows = false;
            this.dgAssocProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssocProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAssocProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssocProd.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssocProd.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgAssocProd.Location = new System.Drawing.Point(430, 396);
            this.dgAssocProd.MultiSelect = false;
            this.dgAssocProd.Name = "dgAssocProd";
            this.dgAssocProd.ReadOnly = true;
            this.dgAssocProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAssocProd.RowHeadersVisible = false;
            this.dgAssocProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgAssocProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgAssocProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssocProd.Size = new System.Drawing.Size(566, 158);
            this.dgAssocProd.TabIndex = 17;
            // 
            // lblPartAssocProd
            // 
            this.lblPartAssocProd.AutoSize = true;
            this.lblPartAssocProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartAssocProd.Location = new System.Drawing.Point(426, 372);
            this.lblPartAssocProd.Name = "lblPartAssocProd";
            this.lblPartAssocProd.Size = new System.Drawing.Size(243, 21);
            this.lblPartAssocProd.TabIndex = 18;
            this.lblPartAssocProd.Text = "Parts Associated with this Product";
            // 
            // btnCandidateAdd
            // 
            this.btnCandidateAdd.Location = new System.Drawing.Point(921, 260);
            this.btnCandidateAdd.Name = "btnCandidateAdd";
            this.btnCandidateAdd.Size = new System.Drawing.Size(75, 26);
            this.btnCandidateAdd.TabIndex = 19;
            this.btnCandidateAdd.Text = "Add";
            this.btnCandidateAdd.UseVisualStyleBackColor = true;
            this.btnCandidateAdd.Click += new System.EventHandler(this.BtnCandidateAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(840, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnProdSave_Click);
            // 
            // btnAssocPartDel
            // 
            this.btnAssocPartDel.Location = new System.Drawing.Point(921, 560);
            this.btnAssocPartDel.Name = "btnAssocPartDel";
            this.btnAssocPartDel.Size = new System.Drawing.Size(75, 23);
            this.btnAssocPartDel.TabIndex = 21;
            this.btnAssocPartDel.Text = "Delete";
            this.btnAssocPartDel.UseVisualStyleBackColor = true;
            this.btnAssocPartDel.Click += new System.EventHandler(this.BtnAssocPartDel_Click);
            // 
            // btnProductCancel
            // 
            this.btnProductCancel.Location = new System.Drawing.Point(921, 606);
            this.btnProductCancel.Name = "btnProductCancel";
            this.btnProductCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProductCancel.TabIndex = 22;
            this.btnProductCancel.Text = "Cancel";
            this.btnProductCancel.UseVisualStyleBackColor = true;
            this.btnProductCancel.Click += new System.EventHandler(this.BtnProductCancel_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 661);
            this.Controls.Add(this.btnProductCancel);
            this.Controls.Add(this.btnAssocPartDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCandidateAdd);
            this.Controls.Add(this.lblPartAssocProd);
            this.Controls.Add(this.dgAssocProd);
            this.Controls.Add(this.tbAllSearch);
            this.Controls.Add(this.btnAllSearch);
            this.Controls.Add(this.lblAllCandParts);
            this.Controls.Add(this.dgAllParts);
            this.Controls.Add(this.tbProductMin);
            this.Controls.Add(this.tbProductMax);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.tbProductInv);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdInventory);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdMax);
            this.Controls.Add(this.lblProdMin);
            this.Controls.Add(this.lblProdId);
            this.Controls.Add(this.lblProd);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssocProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblProdMin;
        private System.Windows.Forms.Label lblProdMax;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdInventory;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.MaskedTextBox tbProductID;
        private System.Windows.Forms.MaskedTextBox tbProductName;
        private System.Windows.Forms.MaskedTextBox tbProductInv;
        private System.Windows.Forms.MaskedTextBox tbProductPrice;
        private System.Windows.Forms.MaskedTextBox tbProductMax;
        private System.Windows.Forms.MaskedTextBox tbProductMin;
        private System.Windows.Forms.DataGridView dgAllParts;
        private System.Windows.Forms.Label lblAllCandParts;
        private System.Windows.Forms.Button btnAllSearch;
        private System.Windows.Forms.MaskedTextBox tbAllSearch;
        private System.Windows.Forms.DataGridView dgAssocProd;
        private System.Windows.Forms.Label lblPartAssocProd;
        private System.Windows.Forms.Button btnCandidateAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAssocPartDel;
        private System.Windows.Forms.Button btnProductCancel;
    }
}