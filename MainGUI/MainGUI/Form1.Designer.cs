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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BruteforceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BruteforceMinUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(18, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Attack Mode";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Bruteforce (Mask Attack)"});
            this.metroComboBox1.Location = new System.Drawing.Point(117, 63);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(646, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(34, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hash Type";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA-256",
            "SHA-512",
            "WPA/WPA2",
            "1Password, agilekeychain",
            "1Password, cloudkeychain",
            "3DES (PT = $salt, key = $pass)",
            "7-Zip",
            "AIX {smd5}",
            "AIX {ssha1}",
            "AIX {ssha256}",
            "AIX {ssha512}",
            "Android FDE (Samsung DEK)",
            "Android FDE <= 4.3",
            "Apache $apr1$ MD5, md5apr1, MD5 (APR)",
            "ArubaOS",
            "Atlassian (PBKDF2-HMAC-SHA1)",
            "AxCrypt",
            "AxCrypt in-memory SHA1",
            "BSDiCrypt, Extended DES",
            "Bitcoin/Litecoin wallet.dat",
            "Blockchain, My Wallet",
            "CRAM-MD5",
            "CRC32",
            "Cisco-ASA MD5",
            "Cisco-IOS $1$ (MD5)",
            "Cisco-IOS $8$ (PBKDF2-SHA256)",
            "Cisco-IOS $9$ (scrypt)",
            "Cisco-IOS type 4 (SHA256)",
            "Cisco-PIX MD5",
            "Citrix NetScaler",
            "ColdFusion 10+",
            "DES (PT = $salt, key = $pass)",
            "DNSSEC (NSEC3)",
            "Django (PBKDF2-SHA256)",
            "Django (SHA-1)",
            "Domain Cached Credentials (DCC), MS Cache",
            "Domain Cached Credentials 2 (DCC2), MS Cache 2",
            "Drupal7",
            "Episerver 6.x < .NET 4",
            "Episerver 6.x >= .NET 4",
            "FileZilla Server >= 0.9.55",
            "FortiGate (FortiOS)",
            "GOST R 34.11-2012 (Streebog) 256-bit",
            "GOST R 34.11-2012 (Streebog) 512-bit",
            "GOST R 34.11-94",
            "GRUB 2",
            "HMAC-MD5 (key = $pass)",
            "HMAC-MD5 (key = $salt)",
            "HMAC-SHA1 (key = $pass)",
            "HMAC-SHA1 (key = $salt)",
            "HMAC-SHA256 (key = $pass)",
            "HMAC-SHA256 (key = $salt)",
            "HMAC-SHA512 (key = $pass)",
            "HMAC-SHA512 (key = $salt)",
            "Half MD5",
            "IKE-PSK MD5",
            "IKE-PSK SHA1",
            "IPB2+ (Invision Power Board)",
            "IPMI2 RAKP HMAC-SHA1",
            "Joomla < 2.5.18",
            "Joomla >= 2.5.18 (MD5)",
            "Juniper IVE",
            "Juniper NetScreen/SSG (ScreenOS)",
            "Juniper/NetBSD sha1crypt",
            "KeePass 1 (AES/Twofish) and KeePass 2 (AES)",
            "Kerberos 5 AS-REQ Pre-Auth etype 23",
            "Kerberos 5 TGS-REP etype 23",
            "LM",
            "LUKS",
            "LastPass + LastPass sniffed",
            "Lotus Notes/Domino 5",
            "Lotus Notes/Domino 6",
            "Lotus Notes/Domino 8",
            "MD4",
            "MS Office 2007",
            "MS Office 2010",
            "MS Office 2013",
            "MS Office <= 2003 $0/$1, MD5 + RC4",
            "MS Office <= 2003 $0/$1, MD5 + RC4, collider #1",
            "MS Office <= 2003 $0/$1, MD5 + RC4, collider #2",
            "MS Office <= 2003 $3/$4, SHA1 + RC4",
            "MS Office <= 2003 $3/$4, SHA1 + RC4, collider #1",
            "MS Office <= 2003 $3/$4, SHA1 + RC4, collider #2",
            "MS-AzureSyncPBKDF2-HMAC-SHA256",
            "MSSQL (2000)",
            "MSSQL (2005)",
            "MSSQL (2012, 2014)",
            "MediaWiki B type",
            "MyBB 1.2+",
            "MySQL CRAM (SHA1)",
            "MySQL323",
            "MySQL4.1/MySQL5",
            "NTLM",
            "NetNTLMv1",
            "NetNTLMv1+ESS",
            "NetNTLMv2",
            "OSX v10.4, OSX v10.5, OSX v10.6",
            "OSX v10.7",
            "OSX v10.8+ (PBKDF2-SHA512)",
            "OpenCart",
            "Oracle H: Type (Oracle 7+)",
            "Oracle S: Type (Oracle 11+)",
            "Oracle T: Type (Oracle 12+)",
            "PBKDF2-HMAC-MD5",
            "PBKDF2-HMAC-SHA1",
            "PBKDF2-HMAC-SHA256",
            "PBKDF2-HMAC-SHA512",
            "PDF 1.1 - 1.3 (Acrobat 2 - 4)",
            "PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #1",
            "PDF 1.1 - 1.3 (Acrobat 2 - 4), collider #2",
            "PDF 1.4 - 1.6 (Acrobat 5 - 8)",
            "PDF 1.7 Level 3 (Acrobat 9)",
            "PDF 1.7 Level 8 (Acrobat 10 - 11)",
            "PHPS",
            "Password Safe v2",
            "Password Safe v3",
            "PeopleSoft",
            "PeopleSoft PS_TOKEN",
            "PostgreSQL",
            "PostgreSQL CRAM (MD5)",
            "PrestaShop",
            "PunBB",
            "RACF",
            "RAR3-hp",
            "RAR5",
            "RIPEMD-160",
            "Radmin2",
            "Redmine",
            "SAP CODVN B (BCODE)",
            "SAP CODVN F/G (PASSCODE)",
            "SAP CODVN H (PWDSALTEDHASH) iSSHA-1",
            "SHA-224",
            "SHA-3 (Keccak)",
            "SHA-384",
            "SIP digest authentication (MD5)",
            "SMF (Simple Machines Forum) > v1.1",
            "SSHA-256(Base64), LDAP {SSHA256}",
            "SSHA-512(Base64), LDAP {SSHA512}",
            "Samsung Android Password/PIN",
            "SipHash",
            "Skip32 (PT = $salt, key = $pass)",
            "Skype",
            "Sybase ASE",
            "WBB3 (Woltlab Burning Board)",
            "Whirlpool",
            "WinZip",
            "Windows Phone 8+ PIN/password",
            "WordPress (MD5)",
            "bcrypt $2*$, Blowfish (Unix)",
            "descrypt, DES (Unix), Traditional DES",
            "eCryptfs",
            "hMailServer",
            "iSCSI CHAP authentication, MD5(CHAP)",
            "iTunes backup < 10.0",
            "iTunes backup >= 10.0",
            "md5($pass.$salt)",
            "md5($salt.$pass)",
            "md5($salt.$pass.$salt)",
            "md5($salt.md5($pass))",
            "md5($salt.md5($pass.$salt))",
            "md5($salt.md5($salt.$pass))",
            "md5($salt.unicode($pass))",
            "md5(md5($pass))",
            "md5(md5($pass).md5($salt))",
            "md5(sha1($pass))",
            "md5(strtoupper(md5($pass)))",
            "md5(unicode($pass).$salt)",
            "md5crypt, MD5 (Unix), Cisco-IOS $1$ (MD5)",
            "nsldap, SHA-1(Base64), Netscape LDAP SHA",
            "nsldaps, SSHA-1(Base64), Netscape LDAP SSHA",
            "osCommerce",
            "phpBB3 (MD5)",
            "phpass",
            "scrypt",
            "sha1($pass.$salt)",
            "sha1($salt.$pass)",
            "sha1($salt.$pass.$salt)",
            "sha1($salt.sha1($pass))",
            "sha1($salt.unicode($pass))",
            "sha1(CX)",
            "sha1(md5($pass))",
            "sha1(sha1($pass))",
            "sha1(unicode($pass).$salt)",
            "sha256($pass.$salt)",
            "sha256($salt.$pass)",
            "sha256($salt.unicode($pass))",
            "sha256(unicode($pass).$salt)",
            "sha256crypt $5$, SHA256 (Unix)",
            "sha512($pass.$salt)",
            "sha512($salt.$pass)",
            "sha512($salt.unicode($pass))",
            "sha512(unicode($pass).$salt)",
            "sha512crypt $6$, SHA512 (Unix)",
            "vBulletin < v3.8.5",
            "vBulletin >= v3.8.5",
            "xt:Commerce"});
            this.metroComboBox2.Location = new System.Drawing.Point(117, 200);
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
            this.BruteforceBox.Location = new System.Drawing.Point(117, 98);
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
            10,
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
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Enabled = false;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(515, 244);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(248, 90);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Crack it!";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(52, 270);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Hashfile";
            // 
            // HashfileTextbox
            // 
            this.HashfileTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HashfileTextbox.Location = new System.Drawing.Point(144, 270);
            this.HashfileTextbox.Name = "HashfileTextbox";
            this.HashfileTextbox.ReadOnly = true;
            this.HashfileTextbox.Size = new System.Drawing.Size(365, 20);
            this.HashfileTextbox.TabIndex = 8;
            this.HashfileTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HashfileTextbox_MouseClick);
            this.HashfileTextbox.TextChanged += new System.EventHandler(this.HashfileTextbox_TextChanged);
            // 
            // HashcatStatusLabel
            // 
            this.HashcatStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashcatStatusLabel.Location = new System.Drawing.Point(119, 293);
            this.HashcatStatusLabel.Name = "HashcatStatusLabel";
            this.HashcatStatusLabel.Size = new System.Drawing.Size(392, 41);
            this.HashcatStatusLabel.TabIndex = 9;
            this.HashcatStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HashcatStatusLabel.Click += new System.EventHandler(this.HashcatStatusLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 385);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(709, 60);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "- - - Cracked hash will be shown here - - -";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(54, 336);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(709, 23);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(54, 359);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(709, 23);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 20);
            this.textBox1.TabIndex = 12;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(73, 244);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Hash";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 247);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 273);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 456);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HashcatStatusLabel);
            this.Controls.Add(this.HashfileTextbox);
            this.Controls.Add(this.metroLabel8);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

