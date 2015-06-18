using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using Microsoft.Win32;
using System.Threading;

namespace Bluetooth_Stack_Tool
{
    public partial class Form1 : Form
    {
        private string INF_PATH = @"\Toshiba\Bluetooth Toshiba Stack\Drivers\tosrfusb\tosrfusb.inf";
        //private string INF_PATH = Directory.GetCurrentDirectory() + @"\tosrfusb.inf";

        private List<string> deviceListID = new List<string>();
        private List<string> deviceListName = new List<string>();

        public Form1()
        {
            InitializeComponent();
            string strProgramFiles = Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") ?? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            INF_PATH = strProgramFiles + INF_PATH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retrieveVIDPID();

            if (Environment.OSVersion.ToString().Contains("6.2."))
            {
                //windows 8;
            }
            else
            {
                groupBoxWin8.Visible = false;
            }
        }
        private void writeLog(string message)
        {
            BeginInvoke((MethodInvoker)delegate()
           {
               textBoxLog.Text += System.Environment.NewLine + message;
               textBoxLog.SelectionStart = textBoxLog.TextLength;
               textBoxLog.ScrollToCaret();
           });
        }

        private void buttonRetrieveDevices_Click(object sender, EventArgs e)
        {
            retrieveVIDPID();
        }

        private void buttonRunInstaller_Click(object sender, EventArgs e)
        {
            runToshibaInstaller();
        }

        private void buttonUpdateINF_Click(object sender, EventArgs e)
        {
            updateINF();
        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {
            patchRegistry();

        }

        private void retrieveVIDPID()
        {
            ManagementClass class1 = new ManagementClass("Win32_PnPEntity");

            foreach (ManagementObject ob in class1.GetInstances())
            {
                Object obj = ob["Name"];
                if (obj == null) continue;

                string objName = obj.ToString();
                if (objName.ToLower().Contains("bluetooth"))
                {
                    Object objDescription = ob["DeviceID"];

                    if (objDescription != null && objDescription.ToString().IndexOf(@"USB\VID_") == 0)
                    {
                        string objDeviceID = objDescription.ToString().Substring(0, 21);
                        deviceListID.Add(objDeviceID);
                        deviceListName.Add(objName);
                        writeLog("Device found: ");
                        writeLog(objName);
                        writeLog(objDeviceID);
                        writeLog("");
                        // MessageBox.Show(objName + "  " + objDescription);
                    }
                }
            }

            if (deviceListID.Count == 0)
            {
                writeLog("No Bluetooth device found");
            }
        }

        private void runToshibaInstaller()
        {
            writeLog("Running Toshiba Bluetooth Stack Installer");

            try
            {
                string toshibaPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                toshibaPath = Path.Combine(toshibaPath, @"Temp\tc00590500a.temp\Setup.exe");

                if (File.Exists(toshibaPath))
                {
                    System.Diagnostics.Process.Start(toshibaPath);
                }

                writeLog(toshibaPath);
                writeLog("Run - Complete");
            }
            catch (Exception ex)
            {
                writeLog("Run - Failed : " + ex.ToString());
            }
        }


        private void updateINF()
        {

            writeLog("Updating INF");
            BeginInvoke((MethodInvoker)delegate()
            {
                buttonUpdateINF.Enabled = false;
            });

            try
            {
                //back up tosrfusb.inf before proceeding
                writeLog("Back up INF");
                if (!File.Exists(INF_PATH))
                {
                    writeLog("Unable to find tosrfusb.inf - Waiting for file to be created");

                    FileSystemWatcher fw = new FileSystemWatcher();
                    fw.Path = @"C:\Program Files (x86)";//Path.GetDirectoryName(INF_PATH);
                    fw.Filter = Path.GetFileName(INF_PATH);
                    fw.IncludeSubdirectories = true;
                    fw.Created += fileSystemWatcher_Created;
                    fw.EnableRaisingEvents = true;

                    return;
                }

                if (!File.Exists(INF_PATH + "_bak"))
                {
                    File.Copy(INF_PATH, INF_PATH + "_bak");
                }


                string stringINF = System.IO.File.ReadAllText(INF_PATH);

                //find for end for first group containing 'TosrfUsb_Device'
                string stringSearch = "TosrfUsb.DeviceDesc";


                int positionText = 0;
                int positionToInsert1 = 0;
                int positionToInsert2 = 0;
                int positionToInsert3 = 0;

                positionText = stringINF.IndexOf(stringSearch, positionText + 1);
                if (positionText > 0)
                {
                    positionToInsert1 = stringINF.IndexOf("\r\n\r\n", positionText);

                }

                int positionIndex = 0;
                int positionIndexEnd = 0;

                positionText = stringINF.LastIndexOf(stringSearch, positionToInsert1, positionToInsert1 - positionText);
                positionIndex = positionText + stringSearch.Length;
                positionIndexEnd = stringINF.IndexOf("%", positionIndex);

                string positionIndexString = stringINF.Substring(positionIndex, positionIndexEnd - positionIndex);

                writeLog(positionIndexString);

                int deviceIndex = Int32.Parse(positionIndexString);


                //find position for second group
                positionText = stringINF.IndexOf(stringSearch, positionToInsert1);
                if (positionText > 0)
                {
                    positionToInsert2 = stringINF.IndexOf("\r\n\r\n", positionText);
                }

                //find position for third group
                positionText = stringINF.IndexOf(stringSearch, positionToInsert2);
                if (positionText > 0)
                {
                    positionToInsert3 = stringINF.IndexOf("\r\n\r\n", positionText);
                    if (positionToInsert3 < 0)
                    {
                        positionToInsert3 = stringINF.Length - 2;
                    }
                }



                string stringToAdd1 = "";
                string stringToAdd3 = "";

                for (int i = 0; i < deviceListID.Count; i++)
                {
                    deviceIndex++;

                    stringToAdd1 = System.Environment.NewLine + "%TosrfUsb.DeviceDesc" + deviceIndex.ToString() +
                        "%=TosrfUsb_Device,  " + deviceListID[i];
                    stringToAdd3 = System.Environment.NewLine + "TosrfUsb.DeviceDesc" + deviceIndex.ToString() +
                        " = \"" + deviceListName[i] + "\"";
                }


                //insert strings from the back
                string stringINFNew = stringINF.Insert(positionToInsert3, stringToAdd3);
                stringINFNew = stringINFNew.Insert(positionToInsert2, stringToAdd1);
                stringINFNew = stringINFNew.Insert(positionToInsert1, stringToAdd1);

                System.IO.File.WriteAllText(INF_PATH, stringINFNew);

                writeLog("Updating INF - Complete");
                BeginInvoke((MethodInvoker)delegate()
                {
                    buttonUpdateINF.Enabled = true;
                });
            }
            catch (Exception ex)
            {
                writeLog("Updating INF - Failed : " + ex.ToString());
                BeginInvoke((MethodInvoker)delegate()
                {
                    buttonUpdateINF.Enabled = true;
                });
            }
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            writeLog("INF file created");
            Thread.Sleep(500);
            updateINF();
        }

        private void patchRegistry()
        {

            writeLog("Patching Registry");

            try
            {
                string keyName = @"HKEY_CURRENT_USER\Software\Toshiba\BluetoothStack\V1.0\Mng";
                Registry.SetValue(keyName, "TestVersion", 0, RegistryValueKind.DWord);

                writeLog("Patching Registry - Complete");
            }
            catch (Exception ex)
            {
                writeLog("Patching Registry - Failed : " + ex.ToString());
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://support.toshiba.com/support/viewContentDetail?contentId=4007183");
            }
            catch (Exception ex)
            {
                writeLog(ex.ToString());
            }
        }

        private void buttonDisableDriver_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.boonjin.com/wp/2015/06/18/disable-driver-signature-enforcement-in-windows-8");
            }
            catch (Exception ex)
            {
                writeLog(ex.ToString());
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Would you like to proceed to restart the computer in Advanced Startup mode?" + System.Environment.NewLine +
                    "Unsaved files may be lost", "Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            System.Diagnostics.Process.Start("shutdown", "/r /o");
                        }
                        break;
                    case DialogResult.Cancel:
                        {
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                writeLog(ex.ToString());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
