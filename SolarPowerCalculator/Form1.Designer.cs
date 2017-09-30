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
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.txtWattage = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.dtInput = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtOutput = new System.Windows.Forms.DataGridView();
            this.cboVoltage = new System.Windows.Forms.ComboBox();
            this.cboDOD = new System.Windows.Forms.ComboBox();
            this.txtPVEfficiency = new System.Windows.Forms.TextBox();
            this.cboExposure = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPcs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(78, 22);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(100, 22);
            this.txtApplianceName.TabIndex = 0;
            // 
            // txtWattage
            // 
            this.txtWattage.Location = new System.Drawing.Point(199, 24);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(59, 22);
            this.txtWattage.TabIndex = 1;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(291, 24);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(48, 22);
            this.txtHours.TabIndex = 2;
            // 
            // dtInput
            // 
            this.dtInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInput.Location = new System.Drawing.Point(12, 65);
            this.dtInput.Name = "dtInput";
            this.dtInput.RowTemplate.Height = 24;
            this.dtInput.Size = new System.Drawing.Size(609, 358);
            this.dtInput.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtOutput
            // 
            this.dtOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOutput.Location = new System.Drawing.Point(12, 498);
            this.dtOutput.Name = "dtOutput";
            this.dtOutput.RowTemplate.Height = 24;
            this.dtOutput.Size = new System.Drawing.Size(609, 210);
            this.dtOutput.TabIndex = 5;
            // 
            // cboVoltage
            // 
            this.cboVoltage.FormattingEnabled = true;
            this.cboVoltage.Location = new System.Drawing.Point(12, 450);
            this.cboVoltage.Name = "cboVoltage";
            this.cboVoltage.Size = new System.Drawing.Size(121, 24);
            this.cboVoltage.TabIndex = 6;
            this.cboVoltage.SelectedIndexChanged += new System.EventHandler(this.cboVoltage_SelectedIndexChanged);
            // 
            // cboDOD
            // 
            this.cboDOD.FormattingEnabled = true;
            this.cboDOD.Location = new System.Drawing.Point(174, 450);
            this.cboDOD.Name = "cboDOD";
            this.cboDOD.Size = new System.Drawing.Size(121, 24);
            this.cboDOD.TabIndex = 7;
            this.cboDOD.SelectedIndexChanged += new System.EventHandler(this.cboDOD_SelectedIndexChanged);
            // 
            // txtPVEfficiency
            // 
            this.txtPVEfficiency.Location = new System.Drawing.Point(339, 452);
            this.txtPVEfficiency.Name = "txtPVEfficiency";
            this.txtPVEfficiency.Size = new System.Drawing.Size(100, 22);
            this.txtPVEfficiency.TabIndex = 8;
            this.txtPVEfficiency.TextChanged += new System.EventHandler(this.txtPVEfficiency_TextChanged);
            // 
            // cboExposure
            // 
            this.cboExposure.FormattingEnabled = true;
            this.cboExposure.Location = new System.Drawing.Point(472, 450);
            this.cboExposure.Name = "cboExposure";
            this.cboExposure.Size = new System.Drawing.Size(121, 24);
            this.cboExposure.TabIndex = 9;
            this.cboExposure.SelectedIndexChanged += new System.EventHandler(this.cboExposure_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(456, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPcs
            // 
            this.txtPcs.Location = new System.Drawing.Point(24, 22);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(48, 22);
            this.txtPcs.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 721);
            this.Controls.Add(this.txtPcs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboExposure);
            this.Controls.Add(this.txtPVEfficiency);
            this.Controls.Add(this.cboDOD);
            this.Controls.Add(this.cboVoltage);
            this.Controls.Add(this.dtOutput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtInput);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtWattage);
            this.Controls.Add(this.txtApplianceName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.TextBox txtWattage;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.DataGridView dtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtOutput;
        private System.Windows.Forms.ComboBox cboVoltage;
        private System.Windows.Forms.ComboBox cboDOD;
        private System.Windows.Forms.TextBox txtPVEfficiency;
        private System.Windows.Forms.ComboBox cboExposure;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPcs;
    }
}

