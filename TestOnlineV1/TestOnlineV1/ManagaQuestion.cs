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
	public partial class ManagaQuestion : Form
	{
		public ManagaQuestion()
		{
			InitializeComponent();
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void txtSearchQSid_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string id = txtSearchQSid.Text;
			DataProcess dp = new DataProcess();
			DataTable dt = dp.SearchData(id);
			if (dt.Rows.Count != 0)
			{
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data!!");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtManaQSid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			rtbContent.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			cbBSu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtA.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtC.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtD.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			string ans = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			if (ans == "_a")
				rdA.Checked = true;
			if (ans == "_b")
				rdB.Checked = true;
			if (ans == "_c")
				rdC.Checked = true;
			if (ans == "_d")
				rdD.Checked = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string id = txtManaQSid.Text;
			string type = cbBSu.Text;
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
			if(dt.UpdateQuestion(id, type, content, a, b, c, d, ans))
			{
				MessageBox.Show("Update Success!!");
				dataGridView1.DataSource = dt.GetQs().DefaultView;
				ResetData();
			}
			else
			{
				MessageBox.Show("Update Faild!!");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			DataProcess db = new DataProcess();
			dataGridView1.DataSource = db.GetQs().DefaultView;
			ResetData();
		}
		private void ResetData()
		{
			rtbContent.Text = "";
			txtManaQSid.Text = "";
			txtA.Text = "";
			txtB.Text = "";
			txtC.Text = "";
			txtD.Text = "";
			cbBSu.Text = null;
			rdA.Checked = false;
			rdB.Checked = false;
			rdC.Checked = false;
			rdD.Checked = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string id = txtManaQSid.Text;
			DataProcess dtb = new DataProcess();
			if (dtb.DeleteQuestion(id))
			{

				dataGridView1.DataSource = dtb.GetQs();
				ResetData();
				MessageBox.Show("Delete Success!!");

			}
			else
			{
				MessageBox.Show("Faild");
			}
		}
	}
}
