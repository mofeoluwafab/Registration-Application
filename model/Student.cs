using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.model
{
	public class Student
	{
		public string UserEmail;
		public string AdmistionNumber;
		public string Basic;
	

		public Student(string userEmail, string admistionNumber , string classes )
		{
			UserEmail = userEmail;
			AdmistionNumber = admistionNumber;
			Basic = classes;
		}
	}
}