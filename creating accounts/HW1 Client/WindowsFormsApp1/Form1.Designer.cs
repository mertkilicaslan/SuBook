
namespace WindowsFormsApp1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textBox_ip = new System.Windows.Forms.TextBox();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.textBox_surname = new System.Windows.Forms.TextBox();
			this.textBox_username = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.clientLogs = new System.Windows.Forms.RichTextBox();
			this.button_createAccount = new System.Windows.Forms.Button();
			this.button_connect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button_disconnect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_ip
			// 
			this.textBox_ip.Location = new System.Drawing.Point(109, 55);
			this.textBox_ip.Name = "textBox_ip";
			this.textBox_ip.Size = new System.Drawing.Size(100, 20);
			this.textBox_ip.TabIndex = 0;
			// 
			// textBox_name
			// 
			this.textBox_name.Enabled = false;
			this.textBox_name.Location = new System.Drawing.Point(109, 194);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(100, 20);
			this.textBox_name.TabIndex = 1;
			// 
			// textBox_surname
			// 
			this.textBox_surname.Enabled = false;
			this.textBox_surname.Location = new System.Drawing.Point(109, 229);
			this.textBox_surname.Name = "textBox_surname";
			this.textBox_surname.Size = new System.Drawing.Size(100, 20);
			this.textBox_surname.TabIndex = 2;
			// 
			// textBox_username
			// 
			this.textBox_username.Enabled = false;
			this.textBox_username.Location = new System.Drawing.Point(109, 264);
			this.textBox_username.Name = "textBox_username";
			this.textBox_username.Size = new System.Drawing.Size(100, 20);
			this.textBox_username.TabIndex = 3;
			// 
			// textBox_password
			// 
			this.textBox_password.Enabled = false;
			this.textBox_password.Location = new System.Drawing.Point(109, 299);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '*';
			this.textBox_password.Size = new System.Drawing.Size(100, 20);
			this.textBox_password.TabIndex = 4;
			this.textBox_password.UseSystemPasswordChar = true;
			// 
			// textBox_port
			// 
			this.textBox_port.Location = new System.Drawing.Point(109, 90);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(100, 20);
			this.textBox_port.TabIndex = 5;
			// 
			// clientLogs
			// 
			this.clientLogs.Location = new System.Drawing.Point(246, 50);
			this.clientLogs.Name = "clientLogs";
			this.clientLogs.ReadOnly = true;
			this.clientLogs.Size = new System.Drawing.Size(202, 308);
			this.clientLogs.TabIndex = 6;
			this.clientLogs.Text = "";
			// 
			// button_createAccount
			// 
			this.button_createAccount.Enabled = false;
			this.button_createAccount.Location = new System.Drawing.Point(134, 335);
			this.button_createAccount.Name = "button_createAccount";
			this.button_createAccount.Size = new System.Drawing.Size(75, 35);
			this.button_createAccount.TabIndex = 7;
			this.button_createAccount.Text = "Create Account";
			this.button_createAccount.UseVisualStyleBackColor = true;
			this.button_createAccount.Click += new System.EventHandler(this.button_createAccount_Click);
			// 
			// button_connect
			// 
			this.button_connect.Location = new System.Drawing.Point(134, 126);
			this.button_connect.Name = "button_connect";
			this.button_connect.Size = new System.Drawing.Size(75, 23);
			this.button_connect.TabIndex = 8;
			this.button_connect.Text = "Connect";
			this.button_connect.UseVisualStyleBackColor = true;
			this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "IP:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Surname:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Username:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 306);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Password:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Port:";
			// 
			// button_disconnect
			// 
			this.button_disconnect.Enabled = false;
			this.button_disconnect.Location = new System.Drawing.Point(373, 377);
			this.button_disconnect.Name = "button_disconnect";
			this.button_disconnect.Size = new System.Drawing.Size(75, 23);
			this.button_disconnect.TabIndex = 15;
			this.button_disconnect.Text = "Disconnect";
			this.button_disconnect.UseVisualStyleBackColor = true;
			this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 436);
			this.Controls.Add(this.button_disconnect);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_connect);
			this.Controls.Add(this.button_createAccount);
			this.Controls.Add(this.clientLogs);
			this.Controls.Add(this.textBox_port);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_username);
			this.Controls.Add(this.textBox_surname);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.textBox_ip);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_ip;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.TextBox textBox_surname;
		private System.Windows.Forms.TextBox textBox_username;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.RichTextBox clientLogs;
		private System.Windows.Forms.Button button_createAccount;
		private System.Windows.Forms.Button button_connect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button_disconnect;
	}
}

