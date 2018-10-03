namespace TestOnlineV1
{
	partial class Login
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
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblincorrect = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(140, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(236, 18);
			this.txtuser.Multiline = true;
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(252, 37);
			this.txtuser.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(236, 85);
			this.txtpass.Multiline = true;
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(252, 37);
			this.txtpass.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TestOnlineV1.Properties.Resources.App_login_manager_icon__1_;
			this.pictureBox1.Location = new System.Drawing.Point(31, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(91, 80);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Image = global::TestOnlineV1.Properties.Resources.Button_Close_icon;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point(365, 219);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 54);
			this.button2.TabIndex = 2;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Image = global::TestOnlineV1.Properties.Resources.Button_Next_icon;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(144, 219);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 54);
			this.button1.TabIndex = 2;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblincorrect
			// 
			this.lblincorrect.AutoSize = true;
			this.lblincorrect.ForeColor = System.Drawing.Color.Red;
			this.lblincorrect.Location = new System.Drawing.Point(194, 185);
			this.lblincorrect.Name = "lblincorrect";
			this.lblincorrect.Size = new System.Drawing.Size(0, 20);
			this.lblincorrect.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Student"});
			this.comboBox1.Location = new System.Drawing.Point(236, 139);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(252, 28);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 298);
			this.ControlBox = false;
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblincorrect);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblincorrect;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}