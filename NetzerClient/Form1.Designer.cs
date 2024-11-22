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
            lblComputerName = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            lblComputerNameField = new Label();
            lblUserNameField = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            lblRamField = new Label();
            lblStorageField = new Label();
            lblProcessorField = new Label();
            lblOperatingSystemField = new Label();
            lblOperatingSystem = new Label();
            lblStorage = new Label();
            lblRam = new Label();
            lblProcessor = new Label();
            groupBox2 = new GroupBox();
            lblMacAddressField = new Label();
            lblIpAddressField = new Label();
            lblIpAddress = new Label();
            lblMacAddress = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.BackColor = Color.FromArgb(224, 224, 224);
            lblComputerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComputerName.ForeColor = Color.FromArgb(64, 64, 64);
            lblComputerName.Location = new Point(28, 44);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(181, 21);
            lblComputerName.TabIndex = 0;
            lblComputerName.Text = "Nome do Computador:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.FromArgb(224, 224, 224);
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(64, 64, 64);
            lblUserName.Location = new Point(28, 75);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(142, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Nome do Usuário:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(224, 224, 224);
            lblTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(192, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Netzer Client";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblComputerNameField
            // 
            lblComputerNameField.AutoSize = true;
            lblComputerNameField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComputerNameField.ForeColor = Color.FromArgb(224, 224, 224);
            lblComputerNameField.Location = new Point(208, 44);
            lblComputerNameField.Name = "lblComputerNameField";
            lblComputerNameField.Size = new Size(174, 21);
            lblComputerNameField.TabIndex = 3;
            lblComputerNameField.Text = "Nome do computador";
            lblComputerNameField.Click += label1_Click;
            // 
            // lblUserNameField
            // 
            lblUserNameField.AutoSize = true;
            lblUserNameField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserNameField.ForeColor = Color.FromArgb(224, 224, 224);
            lblUserNameField.Location = new Point(169, 75);
            lblUserNameField.Name = "lblUserNameField";
            lblUserNameField.Size = new Size(136, 21);
            lblUserNameField.TabIndex = 4;
            lblUserNameField.Text = "Nome do usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblRamField);
            groupBox1.Controls.Add(lblStorageField);
            groupBox1.Controls.Add(lblProcessorField);
            groupBox1.Controls.Add(lblOperatingSystemField);
            groupBox1.Controls.Add(lblOperatingSystem);
            groupBox1.Controls.Add(lblStorage);
            groupBox1.Controls.Add(lblRam);
            groupBox1.Controls.Add(lblProcessor);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 132);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hardware information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(325, 76);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 10;
            label2.Text = "Espaço livre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(231, 76);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 9;
            label1.Text = "Free Space:";
            // 
            // lblRamField
            // 
            lblRamField.AutoSize = true;
            lblRamField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRamField.ForeColor = Color.FromArgb(224, 224, 224);
            lblRamField.Location = new Point(69, 97);
            lblRamField.Name = "lblRamField";
            lblRamField.Size = new Size(143, 21);
            lblRamField.TabIndex = 8;
            lblRamField.Text = "Memória utilizável";
            // 
            // lblStorageField
            // 
            lblStorageField.AutoSize = true;
            lblStorageField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorageField.ForeColor = Color.FromArgb(224, 224, 224);
            lblStorageField.Location = new Point(88, 76);
            lblStorageField.Name = "lblStorageField";
            lblStorageField.Size = new Size(142, 21);
            lblStorageField.TabIndex = 7;
            lblStorageField.Text = "Tamanho do disco";
            // 
            // lblProcessorField
            // 
            lblProcessorField.AutoSize = true;
            lblProcessorField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcessorField.ForeColor = Color.FromArgb(224, 224, 224);
            lblProcessorField.Location = new Point(103, 55);
            lblProcessorField.Name = "lblProcessorField";
            lblProcessorField.Size = new Size(187, 21);
            lblProcessorField.TabIndex = 6;
            lblProcessorField.Text = "Modelo do processador";
            // 
            // lblOperatingSystemField
            // 
            lblOperatingSystemField.AutoSize = true;
            lblOperatingSystemField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperatingSystemField.ForeColor = Color.FromArgb(224, 224, 224);
            lblOperatingSystemField.Location = new Point(160, 34);
            lblOperatingSystemField.Name = "lblOperatingSystemField";
            lblOperatingSystemField.Size = new Size(159, 21);
            lblOperatingSystemField.TabIndex = 6;
            lblOperatingSystemField.Text = "Sistema Operacional";
            // 
            // lblOperatingSystem
            // 
            lblOperatingSystem.AutoSize = true;
            lblOperatingSystem.BackColor = Color.FromArgb(224, 224, 224);
            lblOperatingSystem.ForeColor = Color.FromArgb(64, 64, 64);
            lblOperatingSystem.Location = new Point(16, 34);
            lblOperatingSystem.Name = "lblOperatingSystem";
            lblOperatingSystem.Size = new Size(138, 21);
            lblOperatingSystem.TabIndex = 3;
            lblOperatingSystem.Text = "Operating System:";
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.BackColor = Color.FromArgb(224, 224, 224);
            lblStorage.ForeColor = Color.FromArgb(64, 64, 64);
            lblStorage.Location = new Point(16, 76);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(66, 21);
            lblStorage.TabIndex = 2;
            lblStorage.Text = "Storage:";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.BackColor = Color.FromArgb(224, 224, 224);
            lblRam.ForeColor = Color.FromArgb(64, 64, 64);
            lblRam.Location = new Point(16, 97);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(47, 21);
            lblRam.TabIndex = 1;
            lblRam.Text = "RAM:";
            // 
            // lblProcessor
            // 
            lblProcessor.AutoSize = true;
            lblProcessor.BackColor = Color.FromArgb(224, 224, 224);
            lblProcessor.ForeColor = Color.FromArgb(64, 64, 64);
            lblProcessor.Location = new Point(16, 55);
            lblProcessor.Name = "lblProcessor";
            lblProcessor.Size = new Size(81, 21);
            lblProcessor.TabIndex = 0;
            lblProcessor.Text = "Processor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMacAddressField);
            groupBox2.Controls.Add(lblIpAddressField);
            groupBox2.Controls.Add(lblIpAddress);
            groupBox2.Controls.Add(lblMacAddress);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(12, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 88);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Network information";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblMacAddressField
            // 
            lblMacAddressField.AutoSize = true;
            lblMacAddressField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMacAddressField.ForeColor = Color.FromArgb(224, 224, 224);
            lblMacAddressField.Location = new Point(124, 55);
            lblMacAddressField.Name = "lblMacAddressField";
            lblMacAddressField.Size = new Size(203, 21);
            lblMacAddressField.TabIndex = 6;
            lblMacAddressField.Text = "Mac Adress do dispositivo";
            // 
            // lblIpAddressField
            // 
            lblIpAddressField.AutoSize = true;
            lblIpAddressField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIpAddressField.ForeColor = Color.FromArgb(224, 224, 224);
            lblIpAddressField.Location = new Point(48, 34);
            lblIpAddressField.Name = "lblIpAddressField";
            lblIpAddressField.Size = new Size(217, 21);
            lblIpAddressField.TabIndex = 6;
            lblIpAddressField.Text = "endereço ip do computador";
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.BackColor = Color.FromArgb(224, 224, 224);
            lblIpAddress.ForeColor = Color.FromArgb(64, 64, 64);
            lblIpAddress.Location = new Point(16, 34);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(26, 21);
            lblIpAddress.TabIndex = 4;
            lblIpAddress.Text = "IP:";
            // 
            // lblMacAddress
            // 
            lblMacAddress.AutoSize = true;
            lblMacAddress.BackColor = Color.FromArgb(224, 224, 224);
            lblMacAddress.ForeColor = Color.FromArgb(64, 64, 64);
            lblMacAddress.Location = new Point(16, 55);
            lblMacAddress.Name = "lblMacAddress";
            lblMacAddress.Size = new Size(102, 21);
            lblMacAddress.TabIndex = 0;
            lblMacAddress.Text = "Mac Address:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(532, 347);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblUserNameField);
            Controls.Add(lblComputerNameField);
            Controls.Add(lblTitle);
            Controls.Add(lblUserName);
            Controls.Add(lblComputerName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Netzer Client";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComputerName;
        private Label lblUserName;
        private Label lblTitle;
        private Label lblComputerNameField;
        private Label lblUserNameField;
        private GroupBox groupBox1;
        private Label lblRam;
        private Label lblProcessor;
        private Label lblStorage;
        private Label lblOperatingSystem;
        private Label lblRamField;
        private Label lblStorageField;
        private Label lblProcessorField;
        private Label lblOperatingSystemField;
        private GroupBox groupBox2;
        private Label lblMacAddressField;
        private Label lblIpAddressField;
        private Label lblIpAddress;
        private Label lblMacAddress;
        private Label label2;
        private Label label1;
    }
}
