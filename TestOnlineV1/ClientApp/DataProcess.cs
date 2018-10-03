using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClientApp
{
	public class DataProcess
	{
		public SqlConnection GetConnection()
		{
			SqlConnection conn = null;
			conn = new SqlConnection("server=ASUSK401U\\SQLEXPRESS01;database=TestOnline;uid=sa;pwd=taicuibap");
			return conn;
		}
		public List<Question> GetQuestions()
		{
			List<Question> list = new List<Question>();
			String sql = "SELECT * FROM tblQuestion";
			
			SqlCommand cmd = new SqlCommand(sql,GetConnection());
			cmd.Connection.Open();
			SqlDataReader rd = cmd.ExecuteReader();
			while(rd.Read())
			{
				Question q = new Question();
				q.ID = rd.GetString(0);
				q.Content = rd.GetString(1);
				q.A = rd.GetString(2);
				q.B = rd.GetString(3);
				q.C = rd.GetString(4);
				q.D = rd.GetString(5);
				q.Correct = rd.GetString(7);
				list.Add(q);
			}
			rd.Close();
			cmd.Connection.Close();
			return list;
		}
	}
}
