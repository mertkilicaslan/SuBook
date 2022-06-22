namespace Client
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
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.username_textbox = new System.Windows.Forms.TextBox();
			this.ip_textbox = new System.Windows.Forms.TextBox();
			this.port_textbox = new System.Windows.Forms.TextBox();
			this.logs = new System.Windows.Forms.RichTextBox();
			this.connect_button = new System.Windows.Forms.Button();
			this.disconnect_button = new System.Windows.Forms.Button();
			this.post_Send_Button = new System.Windows.Forms.Button();
			this.post_textbox = new System.Windows.Forms.TextBox();
			this.all_posts_button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.friend_list_listbox = new System.Windows.Forms.ListBox();
			this.add_username_textbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.remove_friend_button = new System.Windows.Forms.Button();
			this.add_friend_button = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.post_id_textbox = new System.Windows.Forms.TextBox();
			this.delete_post_button = new System.Windows.Forms.Button();
			this.button_friend_post = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.my_post_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(71, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Username:";
			// 
			// username_textbox
			// 
			this.username_textbox.Location = new System.Drawing.Point(107, 142);
			this.username_textbox.Name = "username_textbox";
			this.username_textbox.Size = new System.Drawing.Size(110, 20);
			this.username_textbox.TabIndex = 8;
			// 
			// ip_textbox
			// 
			this.ip_textbox.Location = new System.Drawing.Point(107, 60);
			this.ip_textbox.Name = "ip_textbox";
			this.ip_textbox.Size = new System.Drawing.Size(110, 20);
			this.ip_textbox.TabIndex = 10;
			// 
			// port_textbox
			// 
			this.port_textbox.Location = new System.Drawing.Point(107, 102);
			this.port_textbox.Name = "port_textbox";
			this.port_textbox.Size = new System.Drawing.Size(110, 20);
			this.port_textbox.TabIndex = 11;
			// 
			// logs
			// 
			this.logs.Enabled = false;
			this.logs.Location = new System.Drawing.Point(346, 32);
			this.logs.Name = "logs";
			this.logs.ReadOnly = true;
			this.logs.Size = new System.Drawing.Size(271, 455);
			this.logs.TabIndex = 12;
			this.logs.Text = "";
			// 
			// connect_button
			// 
			this.connect_button.Location = new System.Drawing.Point(245, 63);
			this.connect_button.Name = "connect_button";
			this.connect_button.Size = new System.Drawing.Size(81, 32);
			this.connect_button.TabIndex = 13;
			this.connect_button.Text = "Connect";
			this.connect_button.UseVisualStyleBackColor = true;
			this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
			// 
			// disconnect_button
			// 
			this.disconnect_button.Enabled = false;
			this.disconnect_button.Location = new System.Drawing.Point(245, 128);
			this.disconnect_button.Name = "disconnect_button";
			this.disconnect_button.Size = new System.Drawing.Size(81, 34);
			this.disconnect_button.TabIndex = 15;
			this.disconnect_button.Text = "Disconnect";
			this.disconnect_button.UseVisualStyleBackColor = true;
			this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
			// 
			// post_Send_Button
			// 
			this.post_Send_Button.Enabled = false;
			this.post_Send_Button.Location = new System.Drawing.Point(245, 493);
			this.post_Send_Button.Name = "post_Send_Button";
			this.post_Send_Button.Size = new System.Drawing.Size(81, 20);
			this.post_Send_Button.TabIndex = 16;
			this.post_Send_Button.Text = "Send";
			this.post_Send_Button.UseVisualStyleBackColor = true;
			this.post_Send_Button.Click += new System.EventHandler(this.post_Send_Button_Click);
			// 
			// post_textbox
			// 
			this.post_textbox.Enabled = false;
			this.post_textbox.Location = new System.Drawing.Point(107, 493);
			this.post_textbox.Name = "post_textbox";
			this.post_textbox.Size = new System.Drawing.Size(110, 20);
			this.post_textbox.TabIndex = 17;
			// 
			// all_posts_button
			// 
			this.all_posts_button.Enabled = false;
			this.all_posts_button.Location = new System.Drawing.Point(361, 493);
			this.all_posts_button.Name = "all_posts_button";
			this.all_posts_button.Size = new System.Drawing.Size(81, 32);
			this.all_posts_button.TabIndex = 18;
			this.all_posts_button.Text = "All Posts";
			this.all_posts_button.UseVisualStyleBackColor = true;
			this.all_posts_button.Click += new System.EventHandler(this.all_posts_button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 496);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 17);
			this.label3.TabIndex = 19;
			this.label3.Text = "Post:";
			// 
			// friend_list_listbox
			// 
			this.friend_list_listbox.FormattingEnabled = true;
			this.friend_list_listbox.Location = new System.Drawing.Point(91, 215);
			this.friend_list_listbox.Name = "friend_list_listbox";
			this.friend_list_listbox.Size = new System.Drawing.Size(163, 147);
			this.friend_list_listbox.TabIndex = 20;
			// 
			// add_username_textbox
			// 
			this.add_username_textbox.Enabled = false;
			this.add_username_textbox.Location = new System.Drawing.Point(107, 455);
			this.add_username_textbox.Name = "add_username_textbox";
			this.add_username_textbox.Size = new System.Drawing.Size(110, 20);
			this.add_username_textbox.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 455);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Username:";
			// 
			// remove_friend_button
			// 
			this.remove_friend_button.Enabled = false;
			this.remove_friend_button.Location = new System.Drawing.Point(118, 365);
			this.remove_friend_button.Name = "remove_friend_button";
			this.remove_friend_button.Size = new System.Drawing.Size(113, 22);
			this.remove_friend_button.TabIndex = 23;
			this.remove_friend_button.Text = "Remove Friend";
			this.remove_friend_button.UseVisualStyleBackColor = true;
			this.remove_friend_button.Click += new System.EventHandler(this.remove_friend_button_Click);
			// 
			// add_friend_button
			// 
			this.add_friend_button.Enabled = false;
			this.add_friend_button.Location = new System.Drawing.Point(245, 455);
			this.add_friend_button.Name = "add_friend_button";
			this.add_friend_button.Size = new System.Drawing.Size(81, 20);
			this.add_friend_button.TabIndex = 24;
			this.add_friend_button.Text = "Add Friend";
			this.add_friend_button.UseVisualStyleBackColor = true;
			this.add_friend_button.Click += new System.EventHandler(this.add_friend_button_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(44, 532);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 17);
			this.label6.TabIndex = 27;
			this.label6.Text = "Post ID:";
			// 
			// post_id_textbox
			// 
			this.post_id_textbox.Enabled = false;
			this.post_id_textbox.Location = new System.Drawing.Point(107, 531);
			this.post_id_textbox.Name = "post_id_textbox";
			this.post_id_textbox.Size = new System.Drawing.Size(110, 20);
			this.post_id_textbox.TabIndex = 26;
			// 
			// delete_post_button
			// 
			this.delete_post_button.Enabled = false;
			this.delete_post_button.Location = new System.Drawing.Point(245, 531);
			this.delete_post_button.Name = "delete_post_button";
			this.delete_post_button.Size = new System.Drawing.Size(81, 20);
			this.delete_post_button.TabIndex = 25;
			this.delete_post_button.Text = "Delete";
			this.delete_post_button.UseVisualStyleBackColor = true;
			this.delete_post_button.Click += new System.EventHandler(this.delete_post_button_Click);
			// 
			// button_friend_post
			// 
			this.button_friend_post.Enabled = false;
			this.button_friend_post.Location = new System.Drawing.Point(511, 493);
			this.button_friend_post.Name = "button_friend_post";
			this.button_friend_post.Size = new System.Drawing.Size(81, 32);
			this.button_friend_post.TabIndex = 28;
			this.button_friend_post.Text = "Friend\'s Posts";
			this.button_friend_post.UseVisualStyleBackColor = true;
			this.button_friend_post.Click += new System.EventHandler(this.button_friend_post_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(133, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 17);
			this.label7.TabIndex = 29;
			this.label7.Text = "Friend List";
			// 
			// my_post_button
			// 
			this.my_post_button.Enabled = false;
			this.my_post_button.Location = new System.Drawing.Point(438, 531);
			this.my_post_button.Name = "my_post_button";
			this.my_post_button.Size = new System.Drawing.Size(81, 32);
			this.my_post_button.TabIndex = 30;
			this.my_post_button.Text = "My Posts";
			this.my_post_button.UseVisualStyleBackColor = true;
			this.my_post_button.Click += new System.EventHandler(this.my_post_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 581);
			this.Controls.Add(this.my_post_button);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button_friend_post);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.post_id_textbox);
			this.Controls.Add(this.delete_post_button);
			this.Controls.Add(this.add_friend_button);
			this.Controls.Add(this.remove_friend_button);
			this.Controls.Add(this.add_username_textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.friend_list_listbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.all_posts_button);
			this.Controls.Add(this.post_textbox);
			this.Controls.Add(this.post_Send_Button);
			this.Controls.Add(this.disconnect_button);
			this.Controls.Add(this.connect_button);
			this.Controls.Add(this.logs);
			this.Controls.Add(this.port_textbox);
			this.Controls.Add(this.ip_textbox);
			this.Controls.Add(this.username_textbox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button post_Send_Button;
        private System.Windows.Forms.TextBox post_textbox;
        private System.Windows.Forms.Button all_posts_button;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox friend_list_listbox;
		private System.Windows.Forms.TextBox add_username_textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button remove_friend_button;
		private System.Windows.Forms.Button add_friend_button;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox post_id_textbox;
		private System.Windows.Forms.Button delete_post_button;
		private System.Windows.Forms.Button button_friend_post;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button my_post_button;
	}
}

