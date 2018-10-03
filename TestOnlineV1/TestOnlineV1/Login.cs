using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOnlineV1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string user = txtuser.Text;
			string pass = txtpass.Text;
			DataProcess dp = new DataProcess();
			if(dp.login(user,pass))
			{
				
					hethong ht = new hethong();
					ht.FormClosed += new FormClosedEventHandler(ht_FormClosed);
					ht.Show();
					this.Hide();
		
			}
			else
			{
				lblincorrect.Text = "Username Or Passwword Incorrect";
				txtuser.Text = "";
				txtpass.Text = "";
			}
		}

		private void ht_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Show();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
