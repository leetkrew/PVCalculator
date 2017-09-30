using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPowerCalculator.Models
{

    enum outputKeys
    {
        [Description("Total WHr")]
        Total_WHr = 0,

        [Description("Battery Ampere Hour")]
        Battery_AH = 1,

        [Description("PV Required")]
        PV_Watts_Required = 2,

        [Description("Required Wattage")]
        Required_Wattage = 3,

        [Description("Safety Margin")]
        Safety_Margin = 4,

        [Description("Max Current")]
        Max_Current = 5
    }

    class outputFile
    {
        public List<loadsParams> loads { get; set; }
        public int voltage { get; set; }
        public int dod { get; set; }
        public decimal efficiency { get; set; }
        public int exposure { get; set; }
    }

    class loadsParams
    {
        public int pieces { get; set; }
        public string applianceName { get; set; }
        public decimal watts { get; set; }
        public decimal hours { get; set; }
        

    }


    class loadsOutput
    {
        public string key { get; set; }
        public decimal value { get; set; }
    }


}
