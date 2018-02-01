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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbOffGrid = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtOutput = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboExposure = new System.Windows.Forms.ComboBox();
            this.txtPVEfficiency = new System.Windows.Forms.TextBox();
            this.cboDOD = new System.Windows.Forms.ComboBox();
            this.cboVoltage = new System.Windows.Forms.ComboBox();
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
            this.tbGridTie = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbOffGrid.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbOffGrid);
            this.tabControl1.Controls.Add(this.tbGridTie);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 413);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Selecting += this.tabControl1_Selecting;


            // 
            // tbOffGrid
            // 
            this.tbOffGrid.Controls.Add(this.panel3);
            this.tbOffGrid.Controls.Add(this.panel2);
            this.tbOffGrid.Controls.Add(this.panel1);
            this.tbOffGrid.Location = new System.Drawing.Point(4, 22);
            this.tbOffGrid.Name = "tbOffGrid";
            this.tbOffGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tbOffGrid.Size = new System.Drawing.Size(883, 387);
            this.tbOffGrid.TabIndex = 0;
            this.tbOffGrid.Text = "Off Grid";
            this.tbOffGrid.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtOutput);
            this.panel3.Location = new System.Drawing.Point(499, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 269);
            this.panel3.TabIndex = 19;
            // 
            // dtOutput
            // 
            this.dtOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOutput.Location = new System.Drawing.Point(2, 10);
            this.dtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.dtOutput.Name = "dtOutput";
            this.dtOutput.RowTemplate.Height = 24;
            this.dtOutput.Size = new System.Drawing.Size(361, 286);
            this.dtOutput.TabIndex = 6;
            this.dtOutput.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(499, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 50);
            this.panel2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sun Exposure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Efficiency Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Depth of Discharge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Voltage";
            // 
            // cboExposure
            // 
            this.cboExposure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExposure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboExposure.FormattingEnabled = true;
            this.cboExposure.Location = new System.Drawing.Point(272, 20);
            this.cboExposure.Margin = new System.Windows.Forms.Padding(2);
            this.cboExposure.Name = "cboExposure";
            this.cboExposure.Size = new System.Drawing.Size(92, 21);
            this.cboExposure.TabIndex = 11;
            this.cboExposure.SelectedIndexChanged += new System.EventHandler(this.cboExposure_SelectedIndexChanged);
            // 
            // txtPVEfficiency
            // 
            this.txtPVEfficiency.Location = new System.Drawing.Point(193, 20);
            this.txtPVEfficiency.Margin = new System.Windows.Forms.Padding(2);
            this.txtPVEfficiency.Name = "txtPVEfficiency";
            this.txtPVEfficiency.Size = new System.Drawing.Size(76, 20);
            this.txtPVEfficiency.TabIndex = 10;
            this.txtPVEfficiency.TextChanged += new System.EventHandler(this.txtPVEfficiency_TextChanged);
            // 
            // cboDOD
            // 
            this.cboDOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDOD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDOD.FormattingEnabled = true;
            this.cboDOD.Location = new System.Drawing.Point(98, 20);
            this.cboDOD.Margin = new System.Windows.Forms.Padding(2);
            this.cboDOD.Name = "cboDOD";
            this.cboDOD.Size = new System.Drawing.Size(92, 21);
            this.cboDOD.TabIndex = 9;
            this.cboDOD.SelectedIndexChanged += new System.EventHandler(this.cboDOD_SelectedIndexChanged);
            // 
            // cboVoltage
            // 
            this.cboVoltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboVoltage.FormattingEnabled = true;
            this.cboVoltage.Location = new System.Drawing.Point(2, 20);
            this.cboVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.cboVoltage.Name = "cboVoltage";
            this.cboVoltage.Size = new System.Drawing.Size(92, 21);
            this.cboVoltage.TabIndex = 8;
            this.cboVoltage.SelectedIndexChanged += new System.EventHandler(this.cboVoltage_SelectedIndexChanged);
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
            this.panel1.Location = new System.Drawing.Point(-4, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 352);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wattage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Appliance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
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
            this.dtInput.Location = new System.Drawing.Point(16, 44);
            this.dtInput.Margin = new System.Windows.Forms.Padding(2);
            this.dtInput.Name = "dtInput";
            this.dtInput.ReadOnly = true;
            this.dtInput.RowTemplate.Height = 24;
            this.dtInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInput.ShowCellErrors = false;
            this.dtInput.ShowCellToolTips = false;
            this.dtInput.ShowEditingIcon = false;
            this.dtInput.ShowRowErrors = false;
            this.dtInput.Size = new System.Drawing.Size(457, 291);
            this.dtInput.TabIndex = 21;
            this.dtInput.TabStop = false;
            // 
            // txtPcs
            // 
            this.txtPcs.Location = new System.Drawing.Point(16, 20);
            this.txtPcs.Margin = new System.Windows.Forms.Padding(2);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(37, 20);
            this.txtPcs.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 19);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(284, 19);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 19);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(184, 20);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(37, 20);
            this.txtHours.TabIndex = 4;
            // 
            // txtWattage
            // 
            this.txtWattage.Location = new System.Drawing.Point(136, 20);
            this.txtWattage.Margin = new System.Windows.Forms.Padding(2);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(45, 20);
            this.txtWattage.TabIndex = 3;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(56, 20);
            this.txtApplianceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(76, 20);
            this.txtApplianceName.TabIndex = 2;
            // 
            // tbGridTie
            // 
            this.tbGridTie.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbGridTie.Location = new System.Drawing.Point(4, 22);
            this.tbGridTie.Name = "tbGridTie";
            this.tbGridTie.Padding = new System.Windows.Forms.Padding(3);
            this.tbGridTie.Size = new System.Drawing.Size(883, 387);
            this.tbGridTie.TabIndex = 1;
            this.tbGridTie.Text = "Grid Tie";
            this.tbGridTie.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "RJ Regalado (www.rjregalado.com)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 447);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar Panel and Battery Requirement Calculator (by RJ Regalado)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbOffGrid.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbOffGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtOutput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboExposure;
        private System.Windows.Forms.TextBox txtPVEfficiency;
        private System.Windows.Forms.ComboBox cboDOD;
        private System.Windows.Forms.ComboBox cboVoltage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtInput;
        private System.Windows.Forms.TextBox txtPcs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtWattage;
        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.TabPage tbGridTie;
        private System.Windows.Forms.Label label9;
    }
}

