using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace Bluetooth_Stack_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            retrieveVIDPID();
        }

        private void retrieveVIDPID()
        {
            ManagementClass class1 = new ManagementClass("Win32_PnPEntity");


            foreach (ManagementObject ob in class1.GetInstances())
            {
                // PropertyDataCollection properties = ob.Properties;

                Object obj = ob["Name"];
                if (obj == null) continue;

                string objName = obj.ToString();
                if (objName.Contains("Bluetooth"))
                {
                    Object objDescription = ob["DeviceID"];

                    if (objDescription != null && objDescription.ToString().IndexOf(@"USB\VID_") == 0)
                    {
                        Console.WriteLine(ob["Name"]);
                        Console.WriteLine(ob["DeviceID"]);

                        MessageBox.Show(objName + "  " + objDescription);
                    }
                }
            }
        }
    }
}
