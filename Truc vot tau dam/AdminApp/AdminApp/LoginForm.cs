using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
	public partial class LoginForm : Form
	{
		public Staff currentUser = null;//luu tai khoan vua dang nhap thanh cong
		public LoginForm()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string user = txtUser.Text;
			string pass = txtPass.Text;
			AdminModel model = new AdminModel();
			currentUser = model.CheckLogin(user, pass);
			if(currentUser==null)
			{
				MessageBox.Show("Login failed");
			}
			else
			{
				MessageBox.Show("Login Success");
				this.Dispose();
			}
		}
	}
}
