using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolarPowerCalculator.Models;
using Newtonsoft.Json;
using System.IO;
using System.Deployment.Application;

namespace SolarPowerCalculator
{
    public partial class Form1 : Form
    {
        List<loadsParams> applianceList = new List<loadsParams>();
        List<loadsOutput> resultList = new List<loadsOutput>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = string.Format("Solar Panel and Battery Requirement Calculator - v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }

            cboVoltage.Items.Add(12);
            cboVoltage.Items.Add(24);
            cboVoltage.Items.Add(36);
            cboVoltage.Items.Add(48);
            cboVoltage.SelectedIndex = 0;

            cboDOD.Items.Add("none");
            cboDOD.Items.Add("50%");
            cboDOD.Items.Add("100%");
            cboDOD.SelectedIndex = 1;

            txtPVEfficiency.Text = "70";
            
            for (int i = 0; i <= 24; i++)
            {
                cboExposure.Items.Add(i);
            }

            cboExposure.SelectedIndex = 6;

            dtInput.DataSource = applianceList;
            dtOutput.DataSource = resultList;
        }

        private void calculate()
        {
            decimal totalWHr = 0;
            totalWHr = applianceList.Sum((x => x.hours * x.watts * x.pieces));

            if (totalWHr > 0)
            {
                try
                {
                    if ((Convert.ToInt32(txtPVEfficiency.Text) < 1) ||
                        (Convert.ToInt32(txtPVEfficiency.Text) > 100))
                    {
                        txtPVEfficiency.Text = "70";

                    }
                }
                catch
                {
                    txtPVEfficiency.Text = "70";
                }
            }

            resultList.Clear();
            var tmp = new loadsOutput();

            for (int i = 0; i <= Enum.GetNames(typeof(outputKeys)).Length - 1; i++)
            {
                tmp.key = Enum.GetName(typeof(outputKeys), i);

                if (i == (int)outputKeys.Total_WHr)
                {
                    tmp.value = totalWHr;
                }

                if (i == (int)outputKeys.Battery_AH)
                {
                    if ((cboDOD.Text == "none") || (cboDOD.Text == "100%"))
                    {
                        tmp.value = totalWHr / Convert.ToDecimal(cboVoltage.Text);
                    }
                    else if (cboDOD.Text == "50%")
                    {
                        tmp.value = (totalWHr / Convert.ToInt32(cboVoltage.Text)) * 2;
                    }
                }

                if (i == (int)outputKeys.PV_Watts_Required)
                {
                    try
                    {
                        tmp.value = (totalWHr / (Convert.ToDecimal(txtPVEfficiency.Text) / 100)) / Convert.ToDecimal(cboExposure.Text);
                    }
                    catch
                    {
                        tmp.value = 0;
                    }
                }

                if (i == (int)outputKeys.Required_Wattage)
                {
                    tmp.value = applianceList.Sum(x => x.watts);
                }

                if (i == (int)outputKeys.Safety_Margin)
                {
                    tmp.value = applianceList.Sum(x => x.watts) * Convert.ToDecimal(2.5);
                }

                if (i == (int)outputKeys.Max_Current)
                {
                    try
                    {
                        tmp.value = (totalWHr / (Convert.ToDecimal(txtPVEfficiency.Text) / 100)) / Convert.ToDecimal(cboExposure.Text) / Convert.ToDecimal(cboVoltage.Text);
                    }
                    catch
                    {
                        tmp.value = 0;
                    }
                }

                resultList.Add(tmp);

                tmp = new loadsOutput();
            }

            dtOutput.DataSource = null;
            dtOutput.DataSource = resultList;
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Appliance List File (*.lst)|*.lst";

            dialog.InitialDirectory = Properties.Settings.Default.lastDirectory;

            dialog.Title = "Please select a List File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = System.IO.File.ReadAllText(dialog.FileName);

                    var dataObj = new outputFile();
                    dataObj = JsonConvert.DeserializeObject<outputFile>(text);

                    applianceList = dataObj.loads;
                    cboDOD.SelectedIndex = dataObj.dod;
                    cboExposure.SelectedIndex = dataObj.exposure;
                    cboVoltage.SelectedIndex = dataObj.voltage;
                    txtPVEfficiency.Text = dataObj.efficiency.ToString();


                    dtInput.DataSource = null;
                    dtInput.DataSource = applianceList;

                    Properties.Settings.Default.lastDirectory = Path.GetFullPath(dialog.FileName);
                    Properties.Settings.Default.Save();

                    calculate();
                }
                catch (Exception ex)
                {
                    string alert = "";
                    if (ex.InnerException != null)
                    {
                        alert = ex.InnerException.Message;
                    }
                    else
                    {
                        alert = ex.Message;
                    }

                    MessageBox.Show(alert, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var dataObj = new outputFile();
            dataObj.loads = applianceList;
            dataObj.efficiency = Convert.ToDecimal(txtPVEfficiency.Text);
            dataObj.dod = cboDOD.SelectedIndex;
            dataObj.exposure = cboExposure.SelectedIndex;
            dataObj.voltage = cboVoltage.SelectedIndex;

            string data = JsonConvert.SerializeObject(dataObj);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Appliance List File|*.lst";
            saveFileDialog1.Title = "Save List";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                outputFile.WriteLine(data);
                outputFile.Close();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var applianceItem = new loadsParams();

                applianceItem.applianceName = txtApplianceName.Text;
                applianceItem.hours = Convert.ToDecimal(txtHours.Text);
                applianceItem.watts = Convert.ToDecimal(txtWattage.Text);
                applianceItem.pieces = Convert.ToInt32(txtPcs.Text);
                applianceList.Add(applianceItem);

                dtInput.DataSource = null;
                dtInput.DataSource = applianceList;

                calculate();
            }
            catch (Exception ex)
            {
                string alert = "";
                if (ex.InnerException != null)
                {
                    alert = ex.InnerException.Message;
                }
                else
                {
                    alert = ex.Message;
                }

                MessageBox.Show(alert, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cboExposure_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            calculate();
        }

        private void txtPVEfficiency_TextChanged_1(object sender, EventArgs e)
        {
            calculate();
        }

        private void cboDOD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            calculate();
        }

        private void cboVoltage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
