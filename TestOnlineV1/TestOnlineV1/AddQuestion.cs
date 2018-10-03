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
	public partial class AddQuestion : Form
	{
		public AddQuestion()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string id = txtID.Text;
			string type = comboBox1.SelectedItem.ToString();
			type = comboBox1.Text;
			if (type.Equals("Top Notch 1"))
				type = "TN1";
			if (type.Equals("Top Notch 2"))
				type = "TN2";
			if (type.Equals("Top Notch 3"))
				type = "TN3";
			if (type.Equals("Summit 1"))
				type = "S1";
			string content = rtbContent.Text;
			string a = txtA.Text;
			string b = txtB.Text;
			string c = txtC.Text;
			string d = txtD.Text;
			string ans = "";
			if (rdA.Checked)
				ans = "_a";
			if (rdB.Checked)
				ans = "_b";
			if (rdC.Checked)
				ans = "_c";
			if (rdD.Checked)
				ans = "_d";
			DataProcess dt = new DataProcess();
			if (dt.AddQuestion(id, type, content, a, b, c, d, ans))
				MessageBox.Show("Addnew Success!!");
			else
				MessageBox.Show("Addnew Faild!!");
		}
		private void button2_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
		    rtbContent.Text = "";
			txtA.Text = "";
			txtB.Text = "";
			txtC.Text = "";
			txtD.Text = "";
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void AddQuestion_Load(object sender, EventArgs e)
		{

		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{

		}

		private void rtbContent_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
