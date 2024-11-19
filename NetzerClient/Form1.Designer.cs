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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComputerName.ForeColor = Color.FromArgb(224, 224, 224);
            lblComputerName.Location = new Point(12, 43);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(181, 21);
            lblComputerName.TabIndex = 0;
            lblComputerName.Text = "Nome do Computador:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(224, 224, 224);
            lblUserName.Location = new Point(12, 74);
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
            lblComputerNameField.Location = new Point(192, 43);
            lblComputerNameField.Name = "lblComputerNameField";
            lblComputerNameField.Size = new Size(171, 21);
            lblComputerNameField.TabIndex = 3;
            lblComputerNameField.Text = "nome do computador";
            lblComputerNameField.Click += label1_Click;
            // 
            // lblUserNameField
            // 
            lblUserNameField.AutoSize = true;
            lblUserNameField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserNameField.ForeColor = Color.FromArgb(224, 224, 224);
            lblUserNameField.Location = new Point(153, 74);
            lblUserNameField.Name = "lblUserNameField";
            lblUserNameField.Size = new Size(133, 21);
            lblUserNameField.TabIndex = 4;
            lblUserNameField.Text = "nome do usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 160);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hardware information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Processor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 1;
            label2.Text = "RAM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 2;
            label3.Text = "Storage:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(532, 282);
            Controls.Add(groupBox1);
            Controls.Add(lblUserNameField);
            Controls.Add(lblComputerNameField);
            Controls.Add(lblTitle);
            Controls.Add(lblUserName);
            Controls.Add(lblComputerName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Netzer Client";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
