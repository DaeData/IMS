namespace Inventory_Management_System_KKellerman
{
    partial class MainScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgPartMain = new System.Windows.Forms.DataGridView();
            this.dgProductMain = new System.Windows.Forms.DataGridView();
            this.lblPartMain = new System.Windows.Forms.Label();
            this.lblProductsMain = new System.Windows.Forms.Label();
            this.tbPartSearch = new System.Windows.Forms.TextBox();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartModify = new System.Windows.Forms.Button();
            this.btnPartDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Management System";
            // 
            // dgPartMain
            // 
            this.dgPartMain.AllowUserToDeleteRows = false;
            this.dgPartMain.AllowUserToResizeColumns = false;
            this.dgPartMain.AllowUserToResizeRows = false;
            this.dgPartMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPartMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPartMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPartMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPartMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPartMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPartMain.Location = new System.Drawing.Point(12, 238);
            this.dgPartMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgPartMain.Name = "dgPartMain";
            this.dgPartMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPartMain.RowHeadersVisible = false;
            this.dgPartMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgPartMain.RowTemplate.ReadOnly = true;
            this.dgPartMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPartMain.Size = new System.Drawing.Size(601, 233);
            this.dgPartMain.StandardTab = true;
            this.dgPartMain.TabIndex = 1;
            this.dgPartMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPartMain_CellContentClick);
            // 
            // dgProductMain
            // 
            this.dgProductMain.AllowUserToAddRows = false;
            this.dgProductMain.AllowUserToDeleteRows = false;
            this.dgProductMain.AllowUserToResizeColumns = false;
            this.dgProductMain.AllowUserToResizeRows = false;
            this.dgProductMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProductMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProductMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgProductMain.Location = new System.Drawing.Point(689, 238);
            this.dgProductMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProductMain.MultiSelect = false;
            this.dgProductMain.Name = "dgProductMain";
            this.dgProductMain.ReadOnly = true;
            this.dgProductMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProductMain.RowHeadersVisible = false;
            this.dgProductMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgProductMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductMain.Size = new System.Drawing.Size(601, 233);
            this.dgProductMain.StandardTab = true;
            this.dgProductMain.TabIndex = 2;
            this.dgProductMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductMain_CellContentClick);
            // 
            // lblPartMain
            // 
            this.lblPartMain.AutoSize = true;
            this.lblPartMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartMain.Location = new System.Drawing.Point(7, 209);
            this.lblPartMain.Name = "lblPartMain";
            this.lblPartMain.Size = new System.Drawing.Size(53, 25);
            this.lblPartMain.TabIndex = 3;
            this.lblPartMain.Text = "Parts";
            // 
            // lblProductsMain
            // 
            this.lblProductsMain.AutoSize = true;
            this.lblProductsMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsMain.Location = new System.Drawing.Point(684, 207);
            this.lblProductsMain.Name = "lblProductsMain";
            this.lblProductsMain.Size = new System.Drawing.Size(86, 25);
            this.lblProductsMain.TabIndex = 4;
            this.lblProductsMain.Text = "Products";
            // 
            // tbPartSearch
            // 
            this.tbPartSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPartSearch.Location = new System.Drawing.Point(349, 191);
            this.tbPartSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPartSearch.Name = "tbPartSearch";
            this.tbPartSearch.Size = new System.Drawing.Size(206, 25);
            this.tbPartSearch.TabIndex = 5;
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductSearch.Location = new System.Drawing.Point(1025, 194);
            this.tbProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(206, 25);
            this.tbProductSearch.TabIndex = 6;
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartSearch.Location = new System.Drawing.Point(256, 191);
            this.btnPartSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(86, 25);
            this.btnPartSearch.TabIndex = 7;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.Location = new System.Drawing.Point(931, 194);
            this.btnProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(87, 27);
            this.btnProductSearch.TabIndex = 8;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAdd.Location = new System.Drawing.Point(255, 506);
            this.btnPartAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(87, 30);
            this.btnPartAdd.TabIndex = 9;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.BtnPartAdd_Click);
            // 
            // btnPartModify
            // 
            this.btnPartModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartModify.Location = new System.Drawing.Point(349, 506);
            this.btnPartModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartModify.Name = "btnPartModify";
            this.btnPartModify.Size = new System.Drawing.Size(87, 30);
            this.btnPartModify.TabIndex = 10;
            this.btnPartModify.Text = "Modify";
            this.btnPartModify.UseVisualStyleBackColor = true;
            this.btnPartModify.Click += new System.EventHandler(this.BtnPartModify_Click);
            // 
            // btnPartDelete
            // 
            this.btnPartDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartDelete.Location = new System.Drawing.Point(444, 506);
            this.btnPartDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartDelete.Name = "btnPartDelete";
            this.btnPartDelete.Size = new System.Drawing.Size(92, 30);
            this.btnPartDelete.TabIndex = 11;
            this.btnPartDelete.Text = "Delete";
            this.btnPartDelete.UseVisualStyleBackColor = true;
            this.btnPartDelete.Click += new System.EventHandler(this.BtnPartDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Location = new System.Drawing.Point(931, 504);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(87, 30);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductModify.Location = new System.Drawing.Point(1025, 504);
            this.btnProductModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(87, 30);
            this.btnProductModify.TabIndex = 13;
            this.btnProductModify.Text = "Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.BtnProductModify_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.Location = new System.Drawing.Point(1119, 504);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(87, 30);
            this.btnProductDelete.TabIndex = 14;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.BtnProductDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1254, 603);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 666);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnPartDelete);
            this.Controls.Add(this.btnPartModify);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.tbProductSearch);
            this.Controls.Add(this.tbPartSearch);
            this.Controls.Add(this.lblProductsMain);
            this.Controls.Add(this.lblPartMain);
            this.Controls.Add(this.dgProductMain);
            this.Controls.Add(this.dgPartMain);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgPartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgPartMain;
        private System.Windows.Forms.DataGridView dgProductMain;
        private System.Windows.Forms.Label lblPartMain;
        private System.Windows.Forms.Label lblProductsMain;
        private System.Windows.Forms.TextBox tbPartSearch;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartModify;
        private System.Windows.Forms.Button btnPartDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductModify;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

