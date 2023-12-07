using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using registration.model;
using registration.Repository.Interface;

namespace registration.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private string connectionStr;

        public User Create(User obj)
        {
           using(var con = new MySqlConnection(connectionStr))
			
			{
				con.Open();
				string qry = $"insert into address(Email,Role,Pin) values  ('{obj.Email}','{obj.Role}','{obj.Pin}')";
				
				var command = new MySqlCommand(qry);
				command.ExecuteNonQuery();
				return obj;
			}
		}
    }
}