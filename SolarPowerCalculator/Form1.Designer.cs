namespace SolarPowerCalculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInput = new System.Windows.Forms.DataGridView();
            this.txtPcs = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtWattage = new System.Windows.Forms.TextBox();
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboExposure = new System.Windows.Forms.ComboBox();
            this.txtPVEfficiency = new System.Windows.Forms.TextBox();
            this.cboDOD = new System.Windows.Forms.ComboBox();
            this.cboVoltage = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtOutput = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtInput);
            this.panel1.Controls.Add(this.txtPcs);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtHours);
            this.panel1.Controls.Add(this.txtWattage);
            this.panel1.Controls.Add(this.txtApplianceName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 432);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wattage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Appliance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pcs";
            // 
            // dtInput
            // 
            this.dtInput.AllowUserToAddRows = false;
            this.dtInput.AllowUserToDeleteRows = false;
            this.dtInput.AllowUserToResizeColumns = false;
            this.dtInput.AllowUserToResizeRows = false;
            this.dtInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtInput.Location = new System.Drawing.Point(21, 54);
            this.dtInput.Name = "dtInput";
            this.dtInput.ReadOnly = true;
            this.dtInput.RowTemplate.Height = 24;
            this.dtInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInput.ShowCellErrors = false;
            this.dtInput.ShowCellToolTips = false;
            this.dtInput.ShowEditingIcon = false;
            this.dtInput.ShowRowErrors = false;
            this.dtInput.Size = new System.Drawing.Size(609, 358);
            this.dtInput.TabIndex = 21;
            this.dtInput.TabStop = false;
            // 
            // txtPcs
            // 
            this.txtPcs.Location = new System.Drawing.Point(21, 24);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(48, 22);
            this.txtPcs.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(460, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(379, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(246, 24);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(48, 22);
            this.txtHours.TabIndex = 4;
            // 
            // txtWattage
            // 
            this.txtWattage.Location = new System.Drawing.Point(181, 24);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(59, 22);
            this.txtWattage.TabIndex = 3;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(75, 24);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(100, 22);
            this.txtApplianceName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboExposure);
            this.panel2.Controls.Add(this.txtPVEfficiency);
            this.panel2.Controls.Add(this.cboDOD);
            this.panel2.Controls.Add(this.cboVoltage);
            this.panel2.Location = new System.Drawing.Point(683, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 61);
            this.panel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sun Exposure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Efficiency Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Depth of Discharge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Voltage";
            // 
            // cboExposure
            // 
            this.cboExposure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExposure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboExposure.FormattingEnabled = true;
            this.cboExposure.Location = new System.Drawing.Point(363, 24);
            this.cboExposure.Name = "cboExposure";
            this.cboExposure.Size = new System.Drawing.Size(121, 24);
            this.cboExposure.TabIndex = 11;
            this.cboExposure.SelectedIndexChanged += new System.EventHandler(this.cboExposure_SelectedIndexChanged_1);
            // 
            // txtPVEfficiency
            // 
            this.txtPVEfficiency.Location = new System.Drawing.Point(257, 24);
            this.txtPVEfficiency.Name = "txtPVEfficiency";
            this.txtPVEfficiency.Size = new System.Drawing.Size(100, 22);
            this.txtPVEfficiency.TabIndex = 10;
            this.txtPVEfficiency.TextChanged += new System.EventHandler(this.txtPVEfficiency_TextChanged_1);
            // 
            // cboDOD
            // 
            this.cboDOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDOD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDOD.FormattingEnabled = true;
            this.cboDOD.Location = new System.Drawing.Point(130, 24);
            this.cboDOD.Name = "cboDOD";
            this.cboDOD.Size = new System.Drawing.Size(121, 24);
            this.cboDOD.TabIndex = 9;
            this.cboDOD.SelectedIndexChanged += new System.EventHandler(this.cboDOD_SelectedIndexChanged_1);
            // 
            // cboVoltage
            // 
            this.cboVoltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboVoltage.FormattingEnabled = true;
            this.cboVoltage.Location = new System.Drawing.Point(3, 24);
            this.cboVoltage.Name = "cboVoltage";
            this.cboVoltage.Size = new System.Drawing.Size(121, 24);
            this.cboVoltage.TabIndex = 8;
            this.cboVoltage.SelectedIndexChanged += new System.EventHandler(this.cboVoltage_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtOutput);
            this.panel3.Location = new System.Drawing.Point(683, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 330);
            this.panel3.TabIndex = 15;
            // 
            // dtOutput
            // 
            this.dtOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOutput.Location = new System.Drawing.Point(3, 12);
            this.dtOutput.Name = "dtOutput";
            this.dtOutput.RowTemplate.Height = 24;
            this.dtOutput.Size = new System.Drawing.Size(481, 303);
            this.dtOutput.TabIndex = 6;
            this.dtOutput.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "RJ Regalado (www.rjregalado.com)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 451);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar Panel and Battery Requirement Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtInput;
        private System.Windows.Forms.TextBox txtPcs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtWattage;
        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboExposure;
        private System.Windows.Forms.TextBox txtPVEfficiency;
        private System.Windows.Forms.ComboBox cboDOD;
        private System.Windows.Forms.ComboBox cboVoltage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

