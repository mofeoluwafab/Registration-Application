using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using registration.model;
using registration.Repository.Interface;

namespace registration.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
         string connectionStr = "server=localhost; user=root; password=mofeoluwafab";
		public Student Create(Student obj)
		{
			using(var con = new MySqlConnection(connectionStr))
			
			{
				con.Open();
				string qry = $"insert into address(UserEmail,AdmistionNumber,Basic,) values  ('{obj.UserEmail}','{obj.AdmistionNumber}','{obj.Basic}')";
				
				var command = new MySqlCommand(qry);
				command.ExecuteNonQuery();
				return obj;
			}
		}
    }
}