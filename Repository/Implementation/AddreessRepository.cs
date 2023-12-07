using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using registration.model;
using registration.Repository.Interface;

namespace registration.Repository.Implementation
{
	public class AddreessRepository : IAddressRepository
	{
		string connectionStr = "server=localhost; user=root; password=mofeoluwafab";
		public Address Create(Address obj)
		{
			using(var con = new MySqlConnection(connectionStr))
			
			{
				con.Open();
				string qry = $"insert into address(Street,City,State,ZipCode,UserEmail) values  ('{obj.Street}','{obj.City}','{obj.State}','{obj.ZipCode}','{obj.UserEmail}')";
				
				var command = new MySqlCommand(qry);
				command.ExecuteNonQuery();
				return obj;
			}
		}
	}
}

