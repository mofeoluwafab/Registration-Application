using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.model
{
	public class User
	{
		public string Email;
		public string Role;
		public string Pin;

        public User(string email, string role , string pin )
        {
            Email = email;
            Role = role;
            Pin = pin;
        }
    }
}