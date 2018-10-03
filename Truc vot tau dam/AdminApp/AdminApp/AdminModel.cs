using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdminApp
{
	public class AdminModel
	{
		public SqlConnection GetConnection()
		{
			SqlConnection conn = null;
			conn = new SqlConnection("SERVER=ASUSK401U\\SQLEXPRESS01;database=DemoTestOnline;uid=sa;pwd=taicuibap");
			return conn;
		}
		public Staff CheckLogin(string user,string pass)
		{
			string sql = "SELECT * FROM tblStaff WHERE username=@u and password=@p";
			SqlCommand cmd = new SqlCommand(sql,GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@u", user);
			cmd.Parameters.AddWithValue("@p", pass);
			SqlDataReader rd = cmd.ExecuteReader();
			Staff staff = null;
			while(rd.Read())
			{
				staff= new Staff();
				staff.UserName = rd.GetString(0);
				staff.Level = rd.GetInt32(2);
			}
			rd.Close();
			cmd.Connection.Close();
			return staff;
		}
		public bool CheckExist(string id)
		{
			bool result = true;
			string sql = "SELECT * FROM tblExam WHERE _id=@id";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@id",id);
			
			SqlDataReader rd = cmd.ExecuteReader();
			
			while (rd.Read())
			{
				result = false;
				break;
			}
			rd.Close();
			cmd.Connection.Close();
			return result;
		}
		public List<Question> GetQuestions(string type)
		{
			List<Question> list = new List<Question>();
			string sql = "SELECT * FROM tblQuestion WHERE _type = @mt";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@mt", type);
			SqlDataReader red = cmd.ExecuteReader();
			while (red.Read())
			{
				Question qs = new Question();
				qs.ID = red.GetString(0);
				qs.Content = red.GetString(1);
				qs.A = red.GetString(2);
				qs.B = red.GetString(3);
				qs.C = red.GetString(4);
				qs.D = red.GetString(5);
				qs.Correct = red.GetString(6);				
				list.Add(qs);
			}
			red.Close();
			cmd.Connection.Close();
			return list;
		}
		public bool CheckExist(string id, List<Question> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].ID.Equals(id))
					return false;
			}
			//foreach (var item in list)
			//	if (item.ID.Equals(id))
			//		return false;
			return true;
		}
		public List<Question> Get25Questions(string type)
		{
			List<Question> q25 = new List<Question>();
			List<Question> listFull = GetQuestions("TN1");
			int count = 0;
			while (count < 2)
			{
				Random random = new Random();
				int i = random.Next(0, listFull.Count - 1);
				//int i = random.Next(0, GetQuestions(type).Count - 1);
				Question q = GetQuestions(type)[i];
				//if (CheckExist(q.ID, q25))
				{
					q25.Add(q);
					count++;
				}
			}
			return q25;
		}
		public bool AddExam(string id, string date)
		{
			string sql = "INSERT INTO tblExam VALUES(@i,@d,@tt)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@d", date);
			cmd.Parameters.AddWithValue("@tt", "W");
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public bool AddQuestion2Exam(string id, string question)
		{
			string sql = "INSERT INTO tblExamDetail VALUES(@i,@qs)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@qs", question);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public List<Exam> GetExams()
		{
			List<Exam> list = new List<Exam>();
			string sql = "SELECT * FROM tblExam";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			//cmd.Parameters.AddWithValue("@mt", type);
			SqlDataReader red = cmd.ExecuteReader();
			while (red.Read())
			{
				Exam ex = new Exam();
				ex.ID = red.GetString(0);
				ex.Date = red.GetString(1);
				ex.Status = red.GetString(2);
				list.Add(ex);
			}
			red.Close();
			cmd.Connection.Close();
			return list;
		}
		public bool UpdateExam(string id,string date,string status)
		{
			string sql = "UPDATE tblExam SET _date=@d, _status=@s WHERE _id=@i ";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@d", date);
			cmd.Parameters.AddWithValue("@s", status);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}

	}
}
