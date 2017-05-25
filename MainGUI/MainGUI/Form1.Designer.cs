namespace MainGUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.BruteforceBox = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BruteforceMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.BruteforceMinUpDown = new System.Windows.Forms.NumericUpDown();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.HashfileTextbox = new System.Windows.Forms.TextBox();
            this.HashcatStatusLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BruteforceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMinUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Attack Mode";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Bruteforce (Mask Attack)"});
            this.metroComboBox1.Location = new System.Drawing.Point(117, 78);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(646, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(38, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hash Type";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "900 | MD4 ",
            "0 | MD5 ",
            "5100 | Half MD5",
            "100 | SHA1",
            "1300 | SHA-224",
            "1400 | SHA-256",
            "10800 | SHA-384",
            "1700 | SHA-512",
            "5000 | SHA-3 (Keccak)",
            "10100 | SipHash",
            "6000 | RIPEMD-160",
            "6100 | Whirlpool ",
            "6900 | GOST R 34.11-94 ",
            "11700 | GOST R 34.11-2012 (Streebog) 256-bit ",
            "11800 | GOST R 34.11-2012 (Streebog) 512-bit ",
            "10 | md5($pass.$salt)",
            "20 | md5($salt.$pass)",
            "30 | md5(unicode($pass).$salt)",
            "40 | md5($salt.unicode($pass))",
            "3800 | md5($salt.$pass.$salt)",
            "3710 | md5($salt.md5($pass)) ",
            "4010 | md5($salt.md5($salt.$pass)) ",
            "4110 | md5($salt.md5($pass.$salt)) ",
            "2600 | md5(md5($pass)) ",
            "3910 | md5(md5($pass).md5($salt))",
            "4300 | md5(strtoupper(md5($pass))) ",
            "4400 | md5(sha1($pass))",
            "110 | sha1($pass.$salt)",
            "120 | sha1($salt.$pass)",
            "130 | sha1(unicode($pass).$salt)",
            "140 | sha1($salt.unicode($pass))",
            "4500 | sha1(sha1($pass))",
            "4520 | sha1($salt.sha1($pass))",
            "4700 | sha1(md5($pass))",
            "4900 | sha1($salt.$pass.$salt)",
            "14400 | sha1(CX)",
            "1410 | sha256($pass.$salt)",
            "1420 | sha256($salt.$pass)",
            "1430 | sha256(unicode($pass).$salt)",
            "1440 | sha256($salt.unicode($pass))",
            "1710 | sha512($pass.$salt)",
            "1720 | sha512($salt.$pass)",
            "1730 | sha512(unicode($pass).$salt)",
            "1740 | sha512($salt.unicode($pass))",
            "50 | HMAC-MD5 (key = $pass)",
            "60 | HMAC-MD5 (key = $salt)",
            "150 | HMAC-SHA1 (key = $pass)",
            "160 | HMAC-SHA1 (key = $salt)",
            "1450 | HMAC-SHA256 (key = $pass)",
            "1460 | HMAC-SHA256 (key = $salt)",
            "1750 | HMAC-SHA512 (key = $pass)",
            "1760 | HMAC-SHA512 (key = $salt)",
            "14000 | DES (PT = $salt, key = $pass)",
            "14100 | 3DES (PT = $salt, key = $pass) ",
            "14900 | Skip32 (PT = $salt, key = $pass)",
            "400 | phpass ",
            "8900 | scrypt ",
            "11900 | PBKDF2-HMAC-MD5 ",
            "12000 | PBKDF2-HMAC-SHA1",
            "10900 | PBKDF2-HMAC-SHA256 ",
            "12100 | PBKDF2-HMAC-SHA512 ",
            "23 | Skype",
            "2500 | WPA/WPA2",
            "4800 | iSCSI CHAP authentication, MD5(CHAP) ",
            "5300 | IKE-PSK MD5",
            "5400 | IKE-PSK SHA1 ",
            "5500 | NetNTLMv1 ",
            "5500 | NetNTLMv1+ESS",
            "5600 | NetNTLMv2 ",
            "7300 | IPMI2 RAKP HMAC-SHA1",
            "7500 | Kerberos 5 AS-REQ Pre-Auth etype 23",
            "8300 | DNSSEC (NSEC3)",
            "10200 | CRAM-MD5",
            "11100 | PostgreSQL CRAM (MD5) ",
            "11200 | MySQL CRAM (SHA1)",
            "11400 | SIP digest authentication (MD5)",
            "13100 | Kerberos 5 TGS-REP etype 23 ",
            "121 | SMF (Simple Machines Forum) > v1.1",
            "400 | phpBB3 (MD5) ",
            "2611 | vBulletin < v3.8.5 ",
            "2711 | vBulletin >= v3.8.5",
            "2811 | MyBB 1.2+ ",
            "2811 | IPB2+ (Invision Power Board)",
            "8400 | WBB3 (Woltlab Burning Board)",
            "11 | Joomla < 2.5.18 ",
            "400 | Joomla >= 2.5.18 (MD5)",
            "400 | WordPress (MD5) ",
            "2612 | PHPS",
            "7900 | Drupal7",
            "21 | osCommerce",
            "21 | xt:Commerce",
            "11000 | PrestaShop",
            "124 | Django (SHA-1)",
            "10000 | Django (PBKDF2-SHA256)",
            "3711 | MediaWiki B type",
            "13900 | OpenCart",
            "4521 | Redmine",
            "4522 | PunBB",
            "12001 | Atlassian (PBKDF2-HMAC-SHA1)",
            "12 | PostgreSQL",
            "131 | MSSQL (2000) ",
            "132 | MSSQL (2005) ",
            "1731 | MSSQL (2012, 2014) ",
            "200 | MySQL323",
            "300 | MySQL4.1/MySQL5 ",
            "3100 | Oracle H: Type (Oracle 7+)",
            "112 | Oracle S: Type (Oracle 11+) ",
            "12300 | Oracle T: Type (Oracle 12+) ",
            "8000 | Sybase ASE",
            "141 | Episerver 6.x < .NET 4",
            "1441 | Episerver 6.x >= .NET 4",
            "1600 | Apache $apr1$ MD5, md5apr1, MD5 (APR)",
            "12600 | ColdFusion 10+",
            "1421 | hMailServer",
            "101 | nsldap, SHA-1(Base64), Netscape LDAP SHA",
            "111 | nsldaps, SSHA-1(Base64), Netscape LDAP SSHA",
            "1411 | SSHA-256(Base64), LDAP {SSHA256}",
            "1711 | SSHA-512(Base64), LDAP {SSHA512}",
            "15000 | FileZilla Server >= 0.9.55",
            "11500 | CRC32",
            "3000 | LM",
            "1000 | NTLM",
            "1100 | Domain Cached Credentials (DCC), MS Cache",
            "2100 | Domain Cached Credentials 2 (DCC2), MS Cache 2",
            "12800 | MS-AzureSyncPBKDF2-HMAC-SHA256",
            "1500 | descrypt, DES (Unix), Traditional DES",
            "12400 | BSDiCrypt, Extended DES",
            "500 | md5crypt, MD5 (Unix), Cisco-IOS $1$ (MD5)",
            "3200 | bcrypt $2*$, Blowfish (Unix)",
            "7400 | sha256crypt $5$, SHA256 (Unix) ",
            "1800 | sha512crypt $6$, SHA512 (Unix) ",
            "122 | OSX v10.4, OSX v10.5, OSX v10.6",
            "1722 | OSX v10.7 ",
            "7100 | OSX v10.8+ (PBKDF2-SHA512)",
            "6300 | AIX {smd5}",
            "6700 | AIX {ssha1}",
            "6400 | AIX {ssha256}",
            "6500 | AIX {ssha512}",
            "2400 | Cisco-PIX MD5",
            "2410 | Cisco-ASA MD5",
            "500 | Cisco-IOS $1$ (MD5)",
            "5700 | Cisco-IOS type 4 (SHA256)",
            "9200 | Cisco-IOS $8$ (PBKDF2-SHA256)",
            "9300 | Cisco-IOS $9$ (scrypt)",
            "22 | Juniper NetScreen/SSG (ScreenOS)",
            "501 | Juniper IVE",
            "15100 | Juniper/NetBSD sha1crypt ",
            "7000 | FortiGate (FortiOS)",
            "5800 | Samsung Android Password/PIN",
            "13800 | Windows Phone 8+ PIN/password",
            "8100 | Citrix NetScaler",
            "8500 | RACF",
            "7200 | GRUB 2 ",
            "9900 | Radmin2",
            "125 | ArubaOS",
            "7700 | SAP CODVN B (BCODE)",
            "7800 | SAP CODVN F/G (PASSCODE) ",
            "10300 | SAP CODVN H (PWDSALTEDHASH) iSSHA-1",
            "8600 | Lotus Notes/Domino 5",
            "8700 | Lotus Notes/Domino 6",
            "9100 | Lotus Notes/Domino 8",
            "133 | PeopleSoft",
            "13500 | PeopleSoft PS_TOKEN",
            "11600 | 7-Zip",
            "12500 | RAR3-hp",
            "13000 | RAR5",
            "13200 | AxCrypt",
            "13300 | AxCrypt in-memory SHA1",
            "13600 | WinZip ",
            "14700 | iTunes backup < 10.0",
            "14800 | iTunes backup >= 10.0 ",
            "62XY | TrueCrypt ",
            "8800 | Android FDE <= 4.3 ",
            "12900 | Android FDE (Samsung DEK)",
            "12200 | eCryptfs",
            "137XY | VeraCrypt",
            "14600 | LUKS",
            "9700 | MS Office <= 2003 $0/$1, MD5 + RC4",
            "9710 | MS Office <= 2003 $0/$1, MD5 + RC4, collider #1",
            "9720 | MS Office <= 2003 $0/$1, MD5 + RC4, collider #2",
            "9800 | MS Office <= 2003 $3/$4, SHA1 + RC4",
            "9810 | MS Office <= 2003 $3/$4, SHA1 + RC4, collider #1 ",
            "9820 | MS Office <= 2003 $3/$4, SHA1 + RC4, collider #2 ",
            "9400 | MS Office 2007",
            "9500 | MS Office 2010",
            "9600 | MS Office 2013",
            "10400 | PDF 1.1 - 1.3 (Acrobat 2 - 4)",
            "10410 | PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #1 ",
            "10420 | PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #2 ",
            "10500 | PDF 1.4 - 1.6 (Acrobat 5 - 8)",
            "10600 | PDF 1.7 Level 3 (Acrobat 9) ",
            "10700 | PDF 1.7 Level 8 (Acrobat 10 - 11) ",
            "9000 | Password Safe v2",
            "5200 | Password Safe v3",
            "6800 | LastPass + LastPass sniffed ",
            "6600 | 1Password, agilekeychain ",
            "8200 | 1Password, cloudkeychain ",
            "11300 | Bitcoin/Litecoin wallet.dat ",
            "12700 | Blockchain, My Wallet ",
            "13400 | KeePass 1 (AES/Twofish) and KeePass 2 (AES)"});
            this.metroComboBox2.Location = new System.Drawing.Point(117, 215);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(646, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // BruteforceBox
            // 
            this.BruteforceBox.Controls.Add(this.metroLabel4);
            this.BruteforceBox.Controls.Add(this.metroLabel3);
            this.BruteforceBox.Controls.Add(this.BruteforceMaxUpDown);
            this.BruteforceBox.Controls.Add(this.BruteforceMinUpDown);
            this.BruteforceBox.Location = new System.Drawing.Point(117, 113);
            this.BruteforceBox.Name = "BruteforceBox";
            this.BruteforceBox.Size = new System.Drawing.Size(646, 96);
            this.BruteforceBox.TabIndex = 4;
            this.BruteforceBox.TabStop = false;
            this.BruteforceBox.Text = "BruteForce Options";
            this.BruteforceBox.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 57);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Max-Length";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Min-Length";
            // 
            // BruteforceMaxUpDown
            // 
            this.BruteforceMaxUpDown.Location = new System.Drawing.Point(97, 57);
            this.BruteforceMaxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BruteforceMaxUpDown.Name = "BruteforceMaxUpDown";
            this.BruteforceMaxUpDown.Size = new System.Drawing.Size(119, 20);
            this.BruteforceMaxUpDown.TabIndex = 0;
            this.BruteforceMaxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BruteforceMinUpDown
            // 
            this.BruteforceMinUpDown.Location = new System.Drawing.Point(97, 31);
            this.BruteforceMinUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BruteforceMinUpDown.Name = "BruteforceMinUpDown";
            this.BruteforceMinUpDown.Size = new System.Drawing.Size(119, 20);
            this.BruteforceMinUpDown.TabIndex = 0;
            this.BruteforceMinUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(515, 250);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(248, 64);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Crack it!";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(54, 294);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Hashfile";
            // 
            // HashfileTextbox
            // 
            this.HashfileTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HashfileTextbox.Location = new System.Drawing.Point(117, 294);
            this.HashfileTextbox.Name = "HashfileTextbox";
            this.HashfileTextbox.ReadOnly = true;
            this.HashfileTextbox.Size = new System.Drawing.Size(392, 20);
            this.HashfileTextbox.TabIndex = 8;
            this.HashfileTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HashfileTextbox_MouseClick);
            this.HashfileTextbox.TextChanged += new System.EventHandler(this.HashfileTextbox_TextChanged);
            // 
            // HashcatStatusLabel
            // 
            this.HashcatStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashcatStatusLabel.Location = new System.Drawing.Point(117, 250);
            this.HashcatStatusLabel.Name = "HashcatStatusLabel";
            this.HashcatStatusLabel.Size = new System.Drawing.Size(392, 41);
            this.HashcatStatusLabel.TabIndex = 9;
            this.HashcatStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HashcatStatusLabel.Click += new System.EventHandler(this.HashcatStatusLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(709, 83);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 414);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HashcatStatusLabel);
            this.Controls.Add(this.HashfileTextbox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BruteforceBox);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Hashcat GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BruteforceBox.ResumeLayout(false);
            this.BruteforceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMinUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.GroupBox BruteforceBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown BruteforceMaxUpDown;
        private System.Windows.Forms.NumericUpDown BruteforceMinUpDown;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox HashfileTextbox;
        private System.Windows.Forms.Label HashcatStatusLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

