namespace ConsoleApplication4.Forms
{
    partial class ConnectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthenticationMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Database);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AuthenticationMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to server";
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Cancel.Location = new System.Drawing.Point(179, 334);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Connect
            // 
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(168)))), ((int)(((byte)(139)))));
            this.Connect.Location = new System.Drawing.Point(88, 334);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(85, 31);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.Password.Location = new System.Drawing.Point(10, 239);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(244, 30);
            this.Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.Login.Location = new System.Drawing.Point(10, 180);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(244, 30);
            this.Login.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // AuthenticationMode
            // 
            this.AuthenticationMode.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AuthenticationMode.FormattingEnabled = true;
            this.AuthenticationMode.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.AuthenticationMode.Location = new System.Drawing.Point(10, 120);
            this.AuthenticationMode.Name = "AuthenticationMode";
            this.AuthenticationMode.Size = new System.Drawing.Size(244, 31);
            this.AuthenticationMode.TabIndex = 3;
            this.AuthenticationMode.Text = "SQL Server Authentication";
            this.AuthenticationMode.SelectedIndexChanged += new System.EventHandler(this.AuthenticationMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authentication:";
            // 
            // ServerName
            // 
            this.ServerName.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.connectorErrorProvider.SetIconAlignment(this.ServerName, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.connectorErrorProvider.SetIconPadding(this.ServerName, -20);
            this.ServerName.Location = new System.Drawing.Point(10, 60);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(244, 30);
            this.ServerName.TabIndex = 1;
            this.ServerName.Tag = "ServerName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "ServerName";
            this.label1.Text = "Server name:";
            // 
            // connectorErrorProvider
            // 
            this.connectorErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.connectorErrorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Database:";
            // 
            // Database
            // 
            this.Database.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Database.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.Database.Location = new System.Drawing.Point(10, 298);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(244, 30);
            this.Database.TabIndex = 11;
            // 
            // Connector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectorErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AuthenticationMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider connectorErrorProvider;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.Label label5;
    }
}