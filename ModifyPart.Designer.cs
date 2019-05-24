using System;

namespace Inventory_Management_System_KKellerman
{
    partial class ModifyPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbModInHouse = new System.Windows.Forms.RadioButton();
            this.rbModOutsourced = new System.Windows.Forms.RadioButton();
            this.lblModID = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblModInv = new System.Windows.Forms.Label();
            this.lblModCost = new System.Windows.Forms.Label();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.lblModMax = new System.Windows.Forms.Label();
            this.lblModMin = new System.Windows.Forms.Label();
            this.tbModID = new System.Windows.Forms.TextBox();
            this.tbModName = new System.Windows.Forms.MaskedTextBox();
            this.tbModInv = new System.Windows.Forms.MaskedTextBox();
            this.tbModCost = new System.Windows.Forms.MaskedTextBox();
            this.tbModMachineID = new System.Windows.Forms.MaskedTextBox();
            this.tbModMax = new System.Windows.Forms.MaskedTextBox();
            this.tbModMin = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // rbModInHouse
            // 
            this.rbModInHouse.AutoSize = true;
            this.rbModInHouse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModInHouse.Location = new System.Drawing.Point(128, 14);
            this.rbModInHouse.Name = "rbModInHouse";
            this.rbModInHouse.Size = new System.Drawing.Size(78, 21);
            this.rbModInHouse.TabIndex = 1;
            this.rbModInHouse.TabStop = true;
            this.rbModInHouse.Text = "In-House";
            this.rbModInHouse.UseVisualStyleBackColor = true;
            this.rbModInHouse.CheckedChanged += new System.EventHandler(this.RbModInHouse_CheckedChanged);
            // 
            // rbModOutsourced
            // 
            this.rbModOutsourced.AutoSize = true;
            this.rbModOutsourced.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModOutsourced.Location = new System.Drawing.Point(241, 14);
            this.rbModOutsourced.Name = "rbModOutsourced";
            this.rbModOutsourced.Size = new System.Drawing.Size(94, 21);
            this.rbModOutsourced.TabIndex = 2;
            this.rbModOutsourced.TabStop = true;
            this.rbModOutsourced.Text = "Outsourced";
            this.rbModOutsourced.UseVisualStyleBackColor = true;
            this.rbModOutsourced.CheckedChanged += new System.EventHandler(this.RbModOutsourced_CheckedChanged);
            // 
            // lblModID
            // 
            this.lblModID.AutoSize = true;
            this.lblModID.Location = new System.Drawing.Point(119, 89);
            this.lblModID.Name = "lblModID";
            this.lblModID.Size = new System.Drawing.Size(18, 13);
            this.lblModID.TabIndex = 3;
            this.lblModID.Text = "ID";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(102, 123);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(35, 13);
            this.lblModName.TabIndex = 4;
            this.lblModName.Text = "Name";
            // 
            // lblModInv
            // 
            this.lblModInv.AutoSize = true;
            this.lblModInv.Location = new System.Drawing.Point(86, 161);
            this.lblModInv.Name = "lblModInv";
            this.lblModInv.Size = new System.Drawing.Size(51, 13);
            this.lblModInv.TabIndex = 5;
            this.lblModInv.Text = "Inventory";
            // 
            // lblModCost
            // 
            this.lblModCost.AutoSize = true;
            this.lblModCost.Location = new System.Drawing.Point(80, 195);
            this.lblModCost.Name = "lblModCost";
            this.lblModCost.Size = new System.Drawing.Size(57, 13);
            this.lblModCost.TabIndex = 6;
            this.lblModCost.Text = "Price/Cost";
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(78, 263);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(59, 13);
            this.lblMachineID.TabIndex = 7;
            this.lblMachineID.Text = "MachineID";
            // 
            // lblModMax
            // 
            this.lblModMax.AutoSize = true;
            this.lblModMax.Location = new System.Drawing.Point(110, 228);
            this.lblModMax.Name = "lblModMax";
            this.lblModMax.Size = new System.Drawing.Size(27, 13);
            this.lblModMax.TabIndex = 8;
            this.lblModMax.Text = "Max";
            // 
            // lblModMin
            // 
            this.lblModMin.AutoSize = true;
            this.lblModMin.Location = new System.Drawing.Point(275, 228);
            this.lblModMin.Name = "lblModMin";
            this.lblModMin.Size = new System.Drawing.Size(24, 13);
            this.lblModMin.TabIndex = 9;
            this.lblModMin.Text = "Min";
            // 
            // tbModID
            // 
            this.tbModID.BackColor = System.Drawing.SystemColors.Control;
            this.tbModID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbModID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModID.Location = new System.Drawing.Point(154, 86);
            this.tbModID.Name = "tbModID";
            this.tbModID.ReadOnly = true;
            this.tbModID.Size = new System.Drawing.Size(100, 25);
            this.tbModID.TabIndex = 10;
            this.tbModID.WordWrap = false;
            this.tbModID.TextChanged += new System.EventHandler(this.TbModID_TextChanged);
            // 
            // tbModName
            // 
            this.tbModName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbModName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModName.Location = new System.Drawing.Point(154, 120);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(100, 25);
            this.tbModName.TabIndex = 11;
            this.tbModName.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbModName.TextChanged += new System.EventHandler(this.TbModName_TextChanged);
            // 
            // tbModInv
            // 
            this.tbModInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModInv.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbModInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModInv.HidePromptOnLeave = true;
            this.tbModInv.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.tbModInv.Location = new System.Drawing.Point(154, 154);
            this.tbModInv.Name = "tbModInv";
            this.tbModInv.ResetOnSpace = false;
            this.tbModInv.Size = new System.Drawing.Size(100, 25);
            this.tbModInv.TabIndex = 12;
            this.tbModInv.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbModCost
            // 
            this.tbModCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModCost.Location = new System.Drawing.Point(154, 188);
            this.tbModCost.Name = "tbModCost";
            this.tbModCost.Size = new System.Drawing.Size(100, 25);
            this.tbModCost.TabIndex = 13;
            // 
            // tbModMachineID
            // 
            this.tbModMachineID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModMachineID.Location = new System.Drawing.Point(154, 256);
            this.tbModMachineID.Name = "tbModMachineID";
            this.tbModMachineID.Size = new System.Drawing.Size(100, 25);
            this.tbModMachineID.TabIndex = 14;
            // 
            // tbModMax
            // 
            this.tbModMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModMax.Location = new System.Drawing.Point(154, 222);
            this.tbModMax.Name = "tbModMax";
            this.tbModMax.Size = new System.Drawing.Size(64, 25);
            this.tbModMax.TabIndex = 15;
            this.tbModMax.Leave += new System.EventHandler(this.TbModMax_Leave);
            this.tbModMax.LostFocus += new System.EventHandler(this.TbModMax_LostFocus);
            // 
            // tbModMin
            // 
            this.tbModMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModMin.Location = new System.Drawing.Point(305, 222);
            this.tbModMin.Name = "tbModMin";
            this.tbModMin.Size = new System.Drawing.Size(64, 25);
            this.tbModMin.TabIndex = 16;
            this.tbModMin.Leave += new System.EventHandler(this.TbModMin_Leave);
            this.tbModMin.LostFocus += new System.EventHandler(this.TbModMin_LostFocus);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(252, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnModSave_Click);
            // 
            // btnModCancel
            // 
            this.btnModCancel.AutoSize = true;
            this.btnModCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModCancel.CausesValidation = false;
            this.btnModCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCancel.Location = new System.Drawing.Point(313, 323);
            this.btnModCancel.Name = "btnModCancel";
            this.btnModCancel.Size = new System.Drawing.Size(56, 27);
            this.btnModCancel.TabIndex = 18;
            this.btnModCancel.Text = "Cancel";
            this.btnModCancel.UseVisualStyleBackColor = true;
            this.btnModCancel.Click += new System.EventHandler(this.BtnModCancel_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 368);
            this.Controls.Add(this.btnModCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbModMin);
            this.Controls.Add(this.tbModMax);
            this.Controls.Add(this.tbModMachineID);
            this.Controls.Add(this.tbModCost);
            this.Controls.Add(this.tbModInv);
            this.Controls.Add(this.tbModName);
            this.Controls.Add(this.tbModID);
            this.Controls.Add(this.lblModMin);
            this.Controls.Add(this.lblModMax);
            this.Controls.Add(this.lblMachineID);
            this.Controls.Add(this.lblModCost);
            this.Controls.Add(this.lblModInv);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblModID);
            this.Controls.Add(this.rbModOutsourced);
            this.Controls.Add(this.rbModInHouse);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbModInHouse;
        private System.Windows.Forms.RadioButton rbModOutsourced;
        private System.Windows.Forms.Label lblModID;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModInv;
        private System.Windows.Forms.Label lblModCost;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.Label lblModMax;
        private System.Windows.Forms.Label lblModMin;
        private System.Windows.Forms.TextBox tbModID;
        private System.Windows.Forms.MaskedTextBox tbModName;
        private System.Windows.Forms.MaskedTextBox tbModInv;
        private System.Windows.Forms.MaskedTextBox tbModCost;
        private System.Windows.Forms.MaskedTextBox tbModMachineID;
        private System.Windows.Forms.MaskedTextBox tbModMax;
        private System.Windows.Forms.MaskedTextBox tbModMin;
        private System.Windows.Forms.Button btnModCancel;
        public System.Windows.Forms.Button btnSave;
    }
}