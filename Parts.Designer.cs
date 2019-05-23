namespace Inventory_Management_System_KKellerman
{
    partial class Parts
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
            this.lblPart = new System.Windows.Forms.Label();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.Label();
            this.partInventory = new System.Windows.Forms.Label();
            this.partCost = new System.Windows.Forms.Label();
            this.partMax = new System.Windows.Forms.Label();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.tbPartCost = new System.Windows.Forms.MaskedTextBox();
            this.tbPartInvenory = new System.Windows.Forms.MaskedTextBox();
            this.tbPartName = new System.Windows.Forms.MaskedTextBox();
            this.tbPartMax = new System.Windows.Forms.MaskedTextBox();
            this.partMin = new System.Windows.Forms.Label();
            this.tbPartMin = new System.Windows.Forms.MaskedTextBox();
            this.lblPartMachineID = new System.Windows.Forms.Label();
            this.tbPartMachineId = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.partCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.Location = new System.Drawing.Point(16, 17);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(84, 25);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "Add Part";
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(168, 20);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(91, 25);
            this.rbInHouse.TabIndex = 1;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.RbInHouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(305, 20);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(109, 25);
            this.rbOutsourced.TabIndex = 2;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.RbOutsourced_CheckedChanged);
            // 
            // partID
            // 
            this.partID.AutoSize = true;
            this.partID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partID.Location = new System.Drawing.Point(105, 145);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(25, 21);
            this.partID.TabIndex = 3;
            this.partID.Text = "ID";
            // 
            // partName
            // 
            this.partName.AutoSize = true;
            this.partName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partName.Location = new System.Drawing.Point(84, 180);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(52, 21);
            this.partName.TabIndex = 4;
            this.partName.Text = "Name";
            // 
            // partInventory
            // 
            this.partInventory.AutoSize = true;
            this.partInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInventory.Location = new System.Drawing.Point(62, 217);
            this.partInventory.Name = "partInventory";
            this.partInventory.Size = new System.Drawing.Size(76, 21);
            this.partInventory.TabIndex = 5;
            this.partInventory.Text = "Inventory";
            // 
            // partCost
            // 
            this.partCost.AutoSize = true;
            this.partCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCost.Location = new System.Drawing.Point(55, 255);
            this.partCost.Name = "partCost";
            this.partCost.Size = new System.Drawing.Size(81, 21);
            this.partCost.TabIndex = 6;
            this.partCost.Text = "Price/Cost";
            // 
            // partMax
            // 
            this.partMax.AutoSize = true;
            this.partMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMax.Location = new System.Drawing.Point(91, 296);
            this.partMax.Name = "partMax";
            this.partMax.Size = new System.Drawing.Size(39, 21);
            this.partMax.TabIndex = 7;
            this.partMax.Text = "Max";
            // 
            // tbPartID
            // 
            this.tbPartID.AcceptsTab = true;
            this.tbPartID.Location = new System.Drawing.Point(144, 141);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(100, 25);
            this.tbPartID.TabIndex = 8;
            // 
            // tbPartCost
            // 
            this.tbPartCost.AllowPromptAsInput = false;
            this.tbPartCost.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartCost.HidePromptOnLeave = true;
            this.tbPartCost.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartCost.Location = new System.Drawing.Point(144, 255);
            this.tbPartCost.Name = "tbPartCost";
            this.tbPartCost.Size = new System.Drawing.Size(100, 25);
            this.tbPartCost.TabIndex = 11;
            this.tbPartCost.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbPartInvenory
            // 
            this.tbPartInvenory.AllowPromptAsInput = false;
            this.tbPartInvenory.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartInvenory.HidePromptOnLeave = true;
            this.tbPartInvenory.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartInvenory.Location = new System.Drawing.Point(144, 217);
            this.tbPartInvenory.Name = "tbPartInvenory";
            this.tbPartInvenory.Size = new System.Drawing.Size(100, 25);
            this.tbPartInvenory.TabIndex = 10;
            this.tbPartInvenory.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbPartName
            // 
            this.tbPartName.AllowPromptAsInput = false;
            this.tbPartName.AsciiOnly = true;
            this.tbPartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPartName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartName.HidePromptOnLeave = true;
            this.tbPartName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartName.Location = new System.Drawing.Point(144, 180);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(100, 25);
            this.tbPartName.TabIndex = 9;
            this.tbPartName.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbPartMax
            // 
            this.tbPartMax.AllowPromptAsInput = false;
            this.tbPartMax.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartMax.HidePromptOnLeave = true;
            this.tbPartMax.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartMax.Location = new System.Drawing.Point(144, 296);
            this.tbPartMax.Name = "tbPartMax";
            this.tbPartMax.Size = new System.Drawing.Size(100, 25);
            this.tbPartMax.TabIndex = 12;
            this.tbPartMax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // partMin
            // 
            this.partMin.AutoSize = true;
            this.partMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMin.Location = new System.Drawing.Point(305, 296);
            this.partMin.Name = "partMin";
            this.partMin.Size = new System.Drawing.Size(37, 21);
            this.partMin.TabIndex = 13;
            this.partMin.Text = "Min";
            // 
            // tbPartMin
            // 
            this.tbPartMin.AllowPromptAsInput = false;
            this.tbPartMin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartMin.HidePromptOnLeave = true;
            this.tbPartMin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartMin.Location = new System.Drawing.Point(348, 292);
            this.tbPartMin.Name = "tbPartMin";
            this.tbPartMin.Size = new System.Drawing.Size(100, 25);
            this.tbPartMin.TabIndex = 13;
            this.tbPartMin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartMin.Leave += new System.EventHandler(this.TbPartMin_Leave);
            // 
            // lblPartMachineID
            // 
            this.lblPartMachineID.AutoSize = true;
            this.lblPartMachineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartMachineID.Location = new System.Drawing.Point(17, 363);
            this.lblPartMachineID.Name = "lblPartMachineID";
            this.lblPartMachineID.Size = new System.Drawing.Size(0, 21);
            this.lblPartMachineID.TabIndex = 15;
            // 
            // tbPartMachineId
            // 
            this.tbPartMachineId.AllowPromptAsInput = false;
            this.tbPartMachineId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbPartMachineId.HidePromptOnLeave = true;
            this.tbPartMachineId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbPartMachineId.Location = new System.Drawing.Point(159, 359);
            this.tbPartMachineId.Name = "tbPartMachineId";
            this.tbPartMachineId.Size = new System.Drawing.Size(100, 25);
            this.tbPartMachineId.TabIndex = 14;
            this.tbPartMachineId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(413, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.PartSave_Click);
            // 
            // partCancel
            // 
            this.partCancel.Location = new System.Drawing.Point(494, 473);
            this.partCancel.Name = "partCancel";
            this.partCancel.Size = new System.Drawing.Size(75, 23);
            this.partCancel.TabIndex = 18;
            this.partCancel.Text = "Cancel";
            this.partCancel.UseVisualStyleBackColor = true;
            this.partCancel.Click += new System.EventHandler(this.PartCancel_Click);
            // 
            // Parts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 528);
            this.Controls.Add(this.partCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPartMachineId);
            this.Controls.Add(this.lblPartMachineID);
            this.Controls.Add(this.tbPartMin);
            this.Controls.Add(this.partMin);
            this.Controls.Add(this.tbPartMax);
            this.Controls.Add(this.tbPartName);
            this.Controls.Add(this.tbPartInvenory);
            this.Controls.Add(this.tbPartCost);
            this.Controls.Add(this.tbPartID);
            this.Controls.Add(this.partMax);
            this.Controls.Add(this.partCost);
            this.Controls.Add(this.partInventory);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.lblPart);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Parts";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.Label partID;
        private System.Windows.Forms.Label partName;
        private System.Windows.Forms.Label partInventory;
        private System.Windows.Forms.Label partCost;
        private System.Windows.Forms.Label partMax;
        private System.Windows.Forms.Label partMin;
        private System.Windows.Forms.Label lblPartMachineID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button partCancel;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.MaskedTextBox tbPartMin;
        private System.Windows.Forms.MaskedTextBox tbPartCost;
        private System.Windows.Forms.MaskedTextBox tbPartInvenory;
        private System.Windows.Forms.MaskedTextBox tbPartName;
        private System.Windows.Forms.MaskedTextBox tbPartMax;
        private System.Windows.Forms.MaskedTextBox tbPartMachineId;
    }
}