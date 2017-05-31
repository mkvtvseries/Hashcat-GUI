using MainGUI.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace MainGUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern string SendMessage(int hWnd, int msg, string wParam, IntPtr lParam);
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );


        private string hashType ="";
        private string attackMode ="";
        private string OS = IsWow64() ?"64" :"32";
        private string hashcatLoc ="";
        private string hashcatFile ="";
        private bool closing = false;
        private string zipFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\7za.exe";


        Dictionary<string, int> map = new Dictionary<string, int>(){{"MD4", 900},
            {"MD5", 0},
            {"Half MD5", 5100},
            {"SHA1", 100},
            {"SHA-224", 1300},
            {"SHA-256", 1400},
            {"SHA-384", 10800},
            {"SHA-512", 1700},
            {"SHA-3 (Keccak)", 5000},
            {"SipHash", 10100},
            {"RIPEMD-160", 6000},
            {"Whirlpool", 6100},
            {"GOST R 34.11-94", 6900},
            {"GOST R 34.11-2012 (Streebog) 256-bit", 11700},
            {"GOST R 34.11-2012 (Streebog) 512-bit", 11800},
            {"md5($pass.$salt)", 10},
            {"md5($salt.$pass)", 20},
            {"md5(unicode($pass).$salt)", 30},
            {"md5($salt.unicode($pass))", 40},
            {"md5($salt.$pass.$salt)", 3800},
            {"md5($salt.md5($pass))", 3710},
            {"md5($salt.md5($salt.$pass))", 4010},
            {"md5($salt.md5($pass.$salt))", 4110},
            {"md5(md5($pass))", 2600},
            {"md5(md5($pass).md5($salt))", 3910},
            {"md5(strtoupper(md5($pass)))", 4300},
            {"md5(sha1($pass))", 4400},
            {"sha1($pass.$salt)", 110},
            {"sha1($salt.$pass)", 120},
            {"sha1(unicode($pass).$salt)", 130},
            {"sha1($salt.unicode($pass))", 140},
            {"sha1(sha1($pass))", 4500},
            {"sha1($salt.sha1($pass))", 4520},
            {"sha1(md5($pass))", 4700},
            {"sha1($salt.$pass.$salt)", 4900},
            {"sha1(CX)", 14400},
            {"sha256($pass.$salt)", 1410},
            {"sha256($salt.$pass)", 1420},
            {"sha256(unicode($pass).$salt)", 1430},
            {"sha256($salt.unicode($pass))", 1440},
            {"sha512($pass.$salt)", 1710},
            {"sha512($salt.$pass)", 1720},
            {"sha512(unicode($pass).$salt)", 1730},
            {"sha512($salt.unicode($pass))", 1740},
            {"HMAC-MD5 (key = $pass)", 50},
            {"HMAC-MD5 (key = $salt)", 60},
            {"HMAC-SHA1 (key = $pass)", 150},
            {"HMAC-SHA1 (key = $salt)", 160},
            {"HMAC-SHA256 (key = $pass)", 1450},
            {"HMAC-SHA256 (key = $salt)", 1460},
            {"HMAC-SHA512 (key = $pass)", 1750},
            {"HMAC-SHA512 (key = $salt)", 1760},
            {"DES (PT = $salt, key = $pass)", 14000},
            {"3DES (PT = $salt, key = $pass)", 14100},
            {"Skip32 (PT = $salt, key = $pass)", 14900},
            {"phpass", 400},
            {"scrypt", 8900},
            {"PBKDF2-HMAC-MD5", 11900},
            {"PBKDF2-HMAC-SHA1", 12000},
            {"PBKDF2-HMAC-SHA256", 10900},
            {"PBKDF2-HMAC-SHA512", 12100},
            {"Skype", 23},
            {"WPA/WPA2", 2500},
            {"iSCSI CHAP authentication, MD5(CHAP)", 4800},
            {"IKE-PSK MD5", 5300},
            {"IKE-PSK SHA1", 5400},
            {"NetNTLMv1", 5500},
            {"NetNTLMv1+ESS", 5500},
            {"NetNTLMv2", 5600},
            {"IPMI2 RAKP HMAC-SHA1", 7300},
            {"Kerberos 5 AS-REQ Pre-Auth etype 23", 7500},
            {"DNSSEC (NSEC3)", 8300},
            {"CRAM-MD5", 10200},
            {"PostgreSQL CRAM (MD5)", 11100},
            {"MySQL CRAM (SHA1)", 11200},
            {"SIP digest authentication (MD5)", 11400},
            {"Kerberos 5 TGS-REP etype 23", 13100},
            {"SMF (Simple Machines Forum) > v1.1", 121},
            {"phpBB3 (MD5)", 400},
            {"vBulletin < v3.8.5", 2611},
            {"vBulletin >= v3.8.5", 2711},
            {"MyBB 1.2+", 2811},
            {"IPB2+ (Invision Power Board)", 2811},
            {"WBB3 (Woltlab Burning Board)", 8400},
            {"Joomla < 2.5.18", 11},
            {"Joomla >= 2.5.18 (MD5)", 400},
            {"WordPress (MD5)", 400},
            {"PHPS", 2612},
            {"Drupal7", 7900},
            {"osCommerce", 21},
            {"xt:Commerce", 21},
            {"PrestaShop", 11000},
            {"Django (SHA-1)", 124},
            {"Django (PBKDF2-SHA256)", 10000},
            {"MediaWiki B type", 3711},
            {"OpenCart", 13900},
            {"Redmine", 4521},
            {"PunBB", 4522},
            {"Atlassian (PBKDF2-HMAC-SHA1)", 12001},
            {"PostgreSQL", 12},
            {"MSSQL (2000)", 131},
            {"MSSQL (2005)", 132},
            {"MSSQL (2012, 2014)", 1731},
            {"MySQL323", 200},
            {"MySQL4.1/MySQL5", 300},
            {"Oracle H: Type (Oracle 7+)", 3100},
            {"Oracle S: Type (Oracle 11+)", 112},
            {"Oracle T: Type (Oracle 12+)", 12300},
            {"Sybase ASE", 8000},
            {"Episerver 6.x < .NET 4", 141},
            {"Episerver 6.x >= .NET 4", 1441},
            {"Apache $apr1$ MD5, md5apr1, MD5 (APR)", 1600},
            {"ColdFusion 10+", 12600},
            {"hMailServer", 1421},
            {"nsldap, SHA-1(Base64), Netscape LDAP SHA", 101},
            {"nsldaps, SSHA-1(Base64), Netscape LDAP SSHA", 111},
            {"SSHA-256(Base64), LDAP {SSHA256}", 1411},
            {"SSHA-512(Base64), LDAP {SSHA512}", 1711},
            {"FileZilla Server >= 0.9.55", 15000},
            {"CRC32", 11500},
            {"LM", 3000},
            {"NTLM", 1000},
            {"Domain Cached Credentials (DCC), MS Cache", 1100},
            {"Domain Cached Credentials 2 (DCC2), MS Cache 2", 2100},
            {"MS-AzureSyncPBKDF2-HMAC-SHA256", 12800},
            {"descrypt, DES (Unix), Traditional DES", 1500},
            {"BSDiCrypt, Extended DES", 12400},
            {"md5crypt, MD5 (Unix), Cisco-IOS $1$ (MD5)", 500},
            {"bcrypt $2*$, Blowfish (Unix)", 3200},
            {"sha256crypt $5$, SHA256 (Unix)", 7400},
            {"sha512crypt $6$, SHA512 (Unix)", 1800},
            {"OSX v10.4, OSX v10.5, OSX v10.6", 122},
            {"OSX v10.7", 1722},
            {"OSX v10.8+ (PBKDF2-SHA512)", 7100},
            {"AIX {smd5}", 6300},
            {"AIX {ssha1}", 6700},
            {"AIX {ssha256}", 6400},
            {"AIX {ssha512}", 6500},
            {"Cisco-PIX MD5", 2400},
            {"Cisco-ASA MD5", 2410},
            {"Cisco-IOS $1$ (MD5)", 500},
            {"Cisco-IOS type 4 (SHA256)", 5700},
            {"Cisco-IOS $8$ (PBKDF2-SHA256)", 9200},
            {"Cisco-IOS $9$ (scrypt)", 9300},
            {"Juniper NetScreen/SSG (ScreenOS)", 22},
            {"Juniper IVE", 501},
            {"Juniper/NetBSD sha1crypt", 15100},
            {"FortiGate (FortiOS)", 7000},
            {"Samsung Android Password/PIN", 5800},
            {"Windows Phone 8+ PIN/password", 13800},
            {"Citrix NetScaler", 8100},
            {"RACF", 8500},
            {"GRUB 2", 7200},
            {"Radmin2", 9900},
            {"ArubaOS", 125},
            {"SAP CODVN B (BCODE)", 7700},
            {"SAP CODVN F/G (PASSCODE)", 7800},
            {"SAP CODVN H (PWDSALTEDHASH) iSSHA-1", 10300},
            {"Lotus Notes/Domino 5", 8600},
            {"Lotus Notes/Domino 6", 8700},
            {"Lotus Notes/Domino 8", 9100},
            {"PeopleSoft", 133},
            {"PeopleSoft PS_TOKEN", 13500},
            {"7-Zip", 11600},
            {"RAR3-hp", 12500},
            {"RAR5", 13000},
            {"AxCrypt", 13200},
            {"AxCrypt in-memory SHA1", 13300},
            {"WinZip", 13600},
            {"iTunes backup < 10.0", 14700},
            {"iTunes backup >= 10.0", 14800},
            {"Android FDE <= 4.3", 8800},
            {"Android FDE (Samsung DEK)", 12900},
            {"eCryptfs", 12200},
            {"LUKS", 14600},
            {"MS Office <= 2003 $0/$1, MD5 + RC4", 9700},
            {"MS Office <= 2003 $0/$1, MD5 + RC4, collider #1", 9710},
            {"MS Office <= 2003 $0/$1, MD5 + RC4, collider #2", 9720},
            {"MS Office <= 2003 $3/$4, SHA1 + RC4", 9800},
            {"MS Office <= 2003 $3/$4, SHA1 + RC4, collider #1", 9810},
            {"MS Office <= 2003 $3/$4, SHA1 + RC4, collider #2", 9820},
            {"MS Office 2007", 9400},
            {"MS Office 2010", 9500},
            {"MS Office 2013", 9600},
            {"PDF 1.1 - 1.3 (Acrobat 2 - 4)", 10400},
            {"PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #1", 10410},
            {"PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #2", 10420},
            {"PDF 1.4 - 1.6 (Acrobat 5 - 8)", 10500},
            {"PDF 1.7 Level 3 (Acrobat 9)", 10600},
            {"PDF 1.7 Level 8 (Acrobat 10 - 11)", 10700},
            {"Password Safe v2", 9000},
            {"Password Safe v3", 5200},
            {"LastPass + LastPass sniffed", 6800},
            {"1Password, agilekeychain", 6600},
            {"1Password, cloudkeychain", 8200},
            {"Bitcoin/Litecoin wallet.dat", 11300},
            {"Blockchain, My Wallet", 12700},
            {"KeePass 1 (AES/Twofish) and KeePass 2 (AES)", 13400}
            };
        Process p = new Process();
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
                pro.Arguments ="x \"" + source +"\" -o" + destination;
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
            hashcatLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\hashcat-3.5.0\\";
            hashcatFile = hashcatLoc +"hashcat" + OS +".exe";
            HashcatCheckRoutine();
            if (!File.Exists(zipFile))
            {
                File.WriteAllBytes(zipFile, Resources._7za);
            }
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
        }
        private bool HashcatLoaded()
        {
            if (hashcatLoc !="" && File.Exists(hashcatFile))
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
                    attackMode ="3";
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashType = map[metroComboBox2.Text].ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!HashcatLoaded())
            {
                return;
            }
            if (HashfileTextbox.Text =="")
            {
                MessageBox.Show("Choose a hashfile!");
                return;
            }

            if (metroButton1.Text =="Crack it!")
            {
                metroButton1.Text = "Stop";
            }
            else
            {
                
                    metroButton1.Text = "Crack it!";
                    metroLabel6.Text = "";
                    metroLabel7.Text = "";
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                    return;

            }
            Core.RunThread(RunCrack);
        }
        private void RunCrack()
        {
            if (!Directory.Exists(hashcatLoc +"cracked"))
            {
                Directory.CreateDirectory(hashcatLoc +"cracked");
            }
            if (File.Exists(hashcatLoc +"hashcat.potfile"))
            {
                try
                {
                    File.Delete(hashcatLoc +"hashcat.potfile");
                }
                catch { }
            }
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            switch (attackMode)
            {
                case"3":

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = hashcatFile;
                    psi.Arguments = " -m " + hashType +" -a " + attackMode +" -i --increment-min " + BruteforceMinUpDown.Value.ToString() +" --increment-max " + BruteforceMaxUpDown.Value.ToString() +" -o " + hashcatLoc +"cracked/" + timestamp +".cracked " + HashfileTextbox.Text;
                    p.StartInfo = psi;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    StreamWriter inputWriter = p.StandardInput;

                    while (!p.StandardOutput.EndOfStream)
                    {
                        string standard_output = p.StandardOutput.ReadLine();
                        if (standard_output.StartsWith("Speed"))
                        {
                            Invoker.SetText(metroLabel6,"Speed:" + Core.StringBetween(":"," (", standard_output));
                        }
                        else if (standard_output.StartsWith("Guess.Mask"))
                        {
                            Invoker.SetText(metroLabel7,"Cracking length:" + Core.StringBetween("[","]", standard_output));
                        }
                    }

                    p.WaitForExit();
                    if (!closing)
                    {
                        if (File.Exists(hashcatLoc +"cracked\\" + timestamp +".cracked"))
                        {
                            Invoker.SetText(richTextBox1, File.ReadAllText(hashcatLoc +"cracked\\" + timestamp +".cracked"));
                            MessageBox.Show("Cracked" + Environment.NewLine);
                        }
                        else
                        {
                            MessageBox.Show("NOT CRACKED");
                            Invoker.SetText(metroButton1, "Crack it!");
                            Invoker.SetText(metroLabel6, "");
                            Invoker.SetText(metroLabel7, "");
                            try
                            {
                                p.Kill();
                            }
                            catch { }
                        }
                    }
                    break;
            }
        }
        private void HashcatCheckRoutine()
        {
            if (HashcatLoaded())
            {
                Invoker.SetText(HashcatStatusLabel,"Hashcat loaded","Green");
                Invoker.ChangeEnabled(metroButton1, true);
                Invoker.ChangeCursor(HashcatStatusLabel, Cursors.Default);
            }
            else
            {
                Invoker.ChangeEnabled(metroButton1, false);
                Invoker.SetText(HashcatStatusLabel,"Hashcat not found!","Red");
                Invoker.ChangeCursor(HashcatStatusLabel, Cursors.Hand);
            }
        }
        private void HashcatStatusLabel_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Text =="Hashcat not found!")
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\hashcat-3.5.0.7z"))
                {
                    HashcatStatusLabel.Text ="Downloading...";
                    Thread thread = new Thread(
                    () =>
                    {
                        Invoker.SetText(HashcatStatusLabel,"Unpacking...");
                        ExtractFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\hashcat-3.5.0.7z", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                        HashcatCheckRoutine();
                    }

                );
                    Core.RunThread_Download("http://boehmer.pro/latest.7z", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\hashcat-3.5.0.7z", thread);
                }

                //ExtractFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\hashcat-3.5.0.7z", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            Core.StopProcesses("hashcat" + OS);
        }
    }
}
