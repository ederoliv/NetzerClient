namespace NetzerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblComputerName = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            lblComputerNameField = new Label();
            lblUserNameField = new Label();
            lblMacAddressField = new Label();
            lblIpAddressField = new Label();
            lblIpAddress = new Label();
            lblMacAddress = new Label();
            panel1 = new Panel();
            lblProcessor = new Label();
            lblRam = new Label();
            lblStorage = new Label();
            lblOperatingSystem = new Label();
            lblOperatingSystemField = new Label();
            lblProcessorField = new Label();
            lblStorageField = new Label();
            lblRamField = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComputerName.ForeColor = Color.FromArgb(23, 166, 127);
            lblComputerName.Location = new Point(64, 52);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(181, 21);
            lblComputerName.TabIndex = 0;
            lblComputerName.Text = "Nome do Computador:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(23, 166, 127);
            lblUserName.Location = new Point(64, 103);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(142, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Nome do Usuário:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 27, 30);
            lblTitle.Location = new Point(108, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Netzer Client";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblComputerNameField
            // 
            lblComputerNameField.AutoSize = true;
            lblComputerNameField.Font = new Font("Segoe UI", 11.25F);
            lblComputerNameField.ForeColor = Color.FromArgb(183, 183, 185);
            lblComputerNameField.Location = new Point(64, 73);
            lblComputerNameField.Name = "lblComputerNameField";
            lblComputerNameField.Size = new Size(158, 20);
            lblComputerNameField.TabIndex = 3;
            lblComputerNameField.Text = "Nome do computador";
            lblComputerNameField.Click += label1_Click;
            // 
            // lblUserNameField
            // 
            lblUserNameField.AutoSize = true;
            lblUserNameField.Font = new Font("Segoe UI", 11.25F);
            lblUserNameField.ForeColor = Color.FromArgb(183, 183, 185);
            lblUserNameField.Location = new Point(64, 124);
            lblUserNameField.Name = "lblUserNameField";
            lblUserNameField.Size = new Size(124, 20);
            lblUserNameField.TabIndex = 4;
            lblUserNameField.Text = "Nome do usuário";
            // 
            // lblMacAddressField
            // 
            lblMacAddressField.AutoSize = true;
            lblMacAddressField.Font = new Font("Segoe UI", 11.25F);
            lblMacAddressField.ForeColor = Color.FromArgb(183, 183, 185);
            lblMacAddressField.Location = new Point(64, 472);
            lblMacAddressField.Name = "lblMacAddressField";
            lblMacAddressField.Size = new Size(183, 20);
            lblMacAddressField.TabIndex = 6;
            lblMacAddressField.Text = "Mac Adress do dispositivo";
            // 
            // lblIpAddressField
            // 
            lblIpAddressField.AutoSize = true;
            lblIpAddressField.Font = new Font("Segoe UI", 11.25F);
            lblIpAddressField.ForeColor = Color.FromArgb(183, 183, 185);
            lblIpAddressField.Location = new Point(64, 427);
            lblIpAddressField.Name = "lblIpAddressField";
            lblIpAddressField.Size = new Size(196, 20);
            lblIpAddressField.TabIndex = 6;
            lblIpAddressField.Text = "endereço ip do computador";
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblIpAddress.ForeColor = Color.FromArgb(23, 166, 127);
            lblIpAddress.Location = new Point(64, 407);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(80, 20);
            lblIpAddress.TabIndex = 4;
            lblIpAddress.Text = "IP Address";
            // 
            // lblMacAddress
            // 
            lblMacAddress.AutoSize = true;
            lblMacAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblMacAddress.ForeColor = Color.FromArgb(23, 166, 127);
            lblMacAddress.Location = new Point(64, 452);
            lblMacAddress.Name = "lblMacAddress";
            lblMacAddress.Size = new Size(100, 20);
            lblMacAddress.TabIndex = 0;
            lblMacAddress.Text = "Mac Address:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 166, 127);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 40);
            panel1.TabIndex = 11;
            // 
            // lblProcessor
            // 
            lblProcessor.AutoSize = true;
            lblProcessor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblProcessor.ForeColor = Color.FromArgb(23, 166, 127);
            lblProcessor.Location = new Point(64, 211);
            lblProcessor.Name = "lblProcessor";
            lblProcessor.Size = new Size(80, 20);
            lblProcessor.TabIndex = 0;
            lblProcessor.Text = "Processor:";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRam.ForeColor = Color.FromArgb(23, 166, 127);
            lblRam.Location = new Point(64, 346);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(46, 20);
            lblRam.TabIndex = 1;
            lblRam.Text = "RAM:";
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblStorage.ForeColor = Color.FromArgb(23, 166, 127);
            lblStorage.Location = new Point(64, 256);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(66, 20);
            lblStorage.TabIndex = 2;
            lblStorage.Text = "Storage:";
            // 
            // lblOperatingSystem
            // 
            lblOperatingSystem.AutoSize = true;
            lblOperatingSystem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblOperatingSystem.ForeColor = Color.FromArgb(23, 166, 127);
            lblOperatingSystem.Location = new Point(64, 166);
            lblOperatingSystem.Name = "lblOperatingSystem";
            lblOperatingSystem.Size = new Size(130, 20);
            lblOperatingSystem.TabIndex = 3;
            lblOperatingSystem.Text = "Operating System";
            // 
            // lblOperatingSystemField
            // 
            lblOperatingSystemField.AutoSize = true;
            lblOperatingSystemField.Font = new Font("Segoe UI", 11.25F);
            lblOperatingSystemField.ForeColor = Color.FromArgb(183, 183, 185);
            lblOperatingSystemField.Location = new Point(64, 186);
            lblOperatingSystemField.Name = "lblOperatingSystemField";
            lblOperatingSystemField.Size = new Size(146, 20);
            lblOperatingSystemField.TabIndex = 6;
            lblOperatingSystemField.Text = "Sistema Operacional";
            // 
            // lblProcessorField
            // 
            lblProcessorField.AutoSize = true;
            lblProcessorField.Font = new Font("Segoe UI", 11.25F);
            lblProcessorField.ForeColor = Color.FromArgb(183, 183, 185);
            lblProcessorField.Location = new Point(64, 231);
            lblProcessorField.Name = "lblProcessorField";
            lblProcessorField.Size = new Size(168, 20);
            lblProcessorField.TabIndex = 6;
            lblProcessorField.Text = "Modelo do processador";
            // 
            // lblStorageField
            // 
            lblStorageField.AutoSize = true;
            lblStorageField.BackColor = Color.Transparent;
            lblStorageField.Font = new Font("Segoe UI", 11.25F);
            lblStorageField.ForeColor = Color.FromArgb(183, 183, 185);
            lblStorageField.Location = new Point(64, 276);
            lblStorageField.Name = "lblStorageField";
            lblStorageField.Size = new Size(130, 20);
            lblStorageField.TabIndex = 7;
            lblStorageField.Text = "Tamanho do disco";
            // 
            // lblRamField
            // 
            lblRamField.AutoSize = true;
            lblRamField.Font = new Font("Segoe UI", 11.25F);
            lblRamField.ForeColor = Color.FromArgb(183, 183, 185);
            lblRamField.Location = new Point(64, 366);
            lblRamField.Name = "lblRamField";
            lblRamField.Size = new Size(132, 20);
            lblRamField.TabIndex = 8;
            lblRamField.Text = "Memória utilizável";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(23, 166, 127);
            label1.Location = new Point(64, 301);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 9;
            label1.Text = "Free Space:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.FromArgb(183, 183, 185);
            label2.Location = new Point(64, 321);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 10;
            label2.Text = "Espaço livre";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 166, 127);
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(16, 16, 20);
            button1.Location = new Point(131, 525);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(86, 33);
            button1.TabIndex = 12;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 259);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(22, 304);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(22, 349);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(22, 410);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(22, 455);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 35);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 20);
            ClientSize = new Size(341, 570);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(lblStorageField);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lblIpAddressField);
            Controls.Add(label2);
            Controls.Add(lblMacAddressField);
            Controls.Add(lblMacAddress);
            Controls.Add(lblOperatingSystem);
            Controls.Add(lblIpAddress);
            Controls.Add(label1);
            Controls.Add(lblProcessor);
            Controls.Add(panel1);
            Controls.Add(lblRamField);
            Controls.Add(lblUserNameField);
            Controls.Add(lblRam);
            Controls.Add(lblComputerNameField);
            Controls.Add(lblUserName);
            Controls.Add(lblStorage);
            Controls.Add(lblComputerName);
            Controls.Add(lblProcessorField);
            Controls.Add(lblOperatingSystemField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Netzer Client";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComputerName;
        private Label lblUserName;
        private Label lblTitle;
        private Label lblComputerNameField;
        private Label lblUserNameField;
        private Label lblMacAddressField;
        private Label lblIpAddressField;
        private Label lblIpAddress;
        private Label lblMacAddress;
        private Panel panel1;
        private Label lblProcessor;
        private Label lblRam;
        private Label lblStorage;
        private Label lblOperatingSystem;
        private Label lblOperatingSystemField;
        private Label lblProcessorField;
        private Label lblStorageField;
        private Label lblRamField;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}
