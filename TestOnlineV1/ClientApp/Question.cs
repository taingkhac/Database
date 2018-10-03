using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
	public class Question
	{
		public string ID { get; set; }
		public string Content { get; set; }
		public string A { get; set; }
		public string B { get; set; }
		public string C { get; set; }
		public string D { get; set; }
		public string Correct { get; set; }
		public string Choice { set; get; }
	}
}
