
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
			this.serverLogs = new System.Windows.Forms.RichTextBox();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.button_listen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// serverLogs
			// 
			this.serverLogs.Location = new System.Drawing.Point(54, 94);
			this.serverLogs.Name = "serverLogs";
			this.serverLogs.ReadOnly = true;
			this.serverLogs.Size = new System.Drawing.Size(323, 186);
			this.serverLogs.TabIndex = 0;
			this.serverLogs.Text = "";
			// 
			// textBox_port
			// 
			this.textBox_port.Location = new System.Drawing.Point(96, 52);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(183, 20);
			this.textBox_port.TabIndex = 1;
			// 
			// button_listen
			// 
			this.button_listen.Location = new System.Drawing.Point(301, 49);
			this.button_listen.Name = "button_listen";
			this.button_listen.Size = new System.Drawing.Size(76, 23);
			this.button_listen.TabIndex = 2;
			this.button_listen.Text = "Listen";
			this.button_listen.UseVisualStyleBackColor = true;
			this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Port:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 328);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_listen);
			this.Controls.Add(this.textBox_port);
			this.Controls.Add(this.serverLogs);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox serverLogs;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.Button button_listen;
		private System.Windows.Forms.Label label1;
	}
}

