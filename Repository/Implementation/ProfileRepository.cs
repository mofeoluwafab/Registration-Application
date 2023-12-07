using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using registration.model;
using registration.Repository.Interface;

namespace registration.Repository.Implementation
{
	public class ProfileRepository : IProfileRepository
	{
		string connectionStr = "server=localhost; user=root; password=mofeoluwafab";
		public Profile Create(Profile obj)
		{
			using(var con = new MySqlConnection(connectionStr))
			
			{
				con.Open();
				string qry = $"insert into address(FirstName,LastName,Age,PhoneNumber,UserEmail) values  ('{obj.FirstName}','{obj.LastName}','{obj.Age}','{obj.PhoneNumber}','{obj.UserEmail}')";
				
				var command = new MySqlCommand(qry);
				command.ExecuteNonQuery();
				return obj;
			}
		}
		
	}
}