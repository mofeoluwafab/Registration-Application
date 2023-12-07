using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registration.Context
{
		public class DataBase
	{
		static void CreateTable(string connectionString)
		{
			System.Console.WriteLine("Name of Schema");
			string Shema = Console.ReadLine();
			using (var connection = MySqlConnection (ConnectionString))
			
			{
				object value = connection.Open();
				var CreateDdCommand = new MySqlCommand(CreateDdCommand, connection);
			}
		}	
	}	
		
}