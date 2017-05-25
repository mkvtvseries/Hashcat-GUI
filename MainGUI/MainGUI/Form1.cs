using MainGUI.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace MainGUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );


        private string hashType = "";
        private string attackMode = "";
        private string OS = IsWow64() ? "64" : "32";
        private string hashcatLoc = "";
        private string hashcatFile = "";
        private string zipFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\7za.exe";

        public Form1()
        {
            InitializeComponent();
        }
        public void ExtractFile(string source, string destination)
        {
            string zPath = zipFile;
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = "x \"" + source + "\" -o" + destination;
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex)
            {
                MessageBox.Show("Could not unpack hashcat!");
            }
        }
        public static bool IsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hashcatLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hashcat-3.5.0\\";
            hashcatFile = hashcatLoc + "hashcat" + OS + ".exe";
            HashcatCheckRoutine();
            if (!File.Exists(zipFile))
            {
                File.WriteAllBytes(zipFile, Resources._7za);
            }
        }
        private bool HashcatLoaded()
        {
            if (hashcatLoc != "" && File.Exists(hashcatFile))
            {
                return true;
            }
            return false;
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BruteforceBox.Visible = false;

            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    BruteforceBox.Visible = true;
                    attackMode = "3";
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashType = metroComboBox2.Text.Split('|')[0].Trim(' ');
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!HashcatLoaded())
            {
                return;
            }
            if (HashfileTextbox.Text == "")
            {
                MessageBox.Show("Choose a hashfile!");
                return;
            }
            if (!Directory.Exists(hashcatLoc + "cracked"))
            {
                Directory.CreateDirectory(hashcatLoc + "cracked");
            }
            if (File.Exists(hashcatLoc + "hashcat.potfile"))
            {
                try
                {
                    File.Delete(hashcatLoc + "hashcat.potfile");
                }
                catch { }
            }
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            switch (attackMode)
            {
                case "3":
                    Process p = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = hashcatFile;
                    psi.Arguments = " -m " + hashType + " -a " + attackMode + " -i --increment-min " + BruteforceMinUpDown.Value.ToString() + " --increment-max " + BruteforceMaxUpDown.Value.ToString() + " -o " + hashcatLoc + "cracked/" + timestamp + ".cracked " + HashfileTextbox.Text;
                    p.StartInfo = psi;
                    p.Start();
                    p.WaitForExit();
                    if (File.Exists(hashcatLoc + "cracked\\" + timestamp + ".cracked"))
                    {
                        richTextBox1.Text = File.ReadAllText(hashcatLoc + "cracked\\" + timestamp + ".cracked");
                        MessageBox.Show("Cracked");
                    }
                    else
                    {
                        MessageBox.Show("NOT CRACKED");
                    }
                    break;
            }
        }
        private void HashcatCheckRoutine()
        {
            if (HashcatLoaded())
            {
                HashcatStatusLabel.ForeColor = Color.Green;
                HashcatStatusLabel.Text = "Hashcat loaded!";
                metroButton1.Enabled = true;
            }
            else
            {
                HashcatStatusLabel.ForeColor = Color.Red;
                HashcatStatusLabel.Text = "Hashcat not found!";
                HashcatStatusLabel.Cursor = Cursors.Hand;
            }
        }
        private void HashcatStatusLabel_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Cursor == Cursors.Hand)
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hashcat-3.5.0.7z"))
                {
                    MessageBox.Show("Please wait while downloading hashcat!" + Environment.NewLine + "In some cases, you have to accept a Popup");
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("http://boehmer.pro/latest.7z", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hashcat-3.5.0.7z");
                    }
                }

                ExtractFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hashcat-3.5.0.7z", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                HashcatCheckRoutine();
            }
        }

        private void HashfileTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HashfileTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == DialogResult.OK)
            {
                HashfileTextbox.Text = opn.FileName;
            }
        }
    }
}
