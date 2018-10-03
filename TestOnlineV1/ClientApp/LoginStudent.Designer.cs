namespace ClientApp
{
	partial class LoginStudent
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(397, 260);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 49);
			this.button2.TabIndex = 0;
			this.button2.Text = "Exit System";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(146, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 50);
			this.button1.TabIndex = 1;
			this.button1.Text = "Login System";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// LoginStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 379);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Name = "LoginStudent";
			this.Text = "LoginStudent";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}