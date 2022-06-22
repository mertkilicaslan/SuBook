namespace Server
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listenport_textbox = new System.Windows.Forms.TextBox();
            this.listen_button = new System.Windows.Forms.Button();
            this.server_logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // listenport_textbox
            // 
            this.listenport_textbox.Location = new System.Drawing.Point(153, 48);
            this.listenport_textbox.Name = "listenport_textbox";
            this.listenport_textbox.Size = new System.Drawing.Size(150, 20);
            this.listenport_textbox.TabIndex = 1;
            // 
            // listen_button
            // 
            this.listen_button.Location = new System.Drawing.Point(326, 45);
            this.listen_button.Name = "listen_button";
            this.listen_button.Size = new System.Drawing.Size(75, 23);
            this.listen_button.TabIndex = 2;
            this.listen_button.Text = "Listen";
            this.listen_button.UseVisualStyleBackColor = true;
            this.listen_button.Click += new System.EventHandler(this.listen_button_Click);
            // 
            // server_logs
            // 
            this.server_logs.Location = new System.Drawing.Point(96, 116);
            this.server_logs.Name = "server_logs";
            this.server_logs.ReadOnly = true;
            this.server_logs.Size = new System.Drawing.Size(322, 342);
            this.server_logs.TabIndex = 3;
            this.server_logs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 542);
            this.Controls.Add(this.server_logs);
            this.Controls.Add(this.listen_button);
            this.Controls.Add(this.listenport_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listenport_textbox;
        private System.Windows.Forms.Button listen_button;
        private System.Windows.Forms.RichTextBox server_logs;
    }
}

