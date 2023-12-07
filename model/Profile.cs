using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.model
{
	public class Profile
	{
	   public string FirstName;
		public string LastName; 
	   public string Age;
	   public string UserEmail;
	   public string PhoneNumber;

        public Profile(string firstName, string lastName, string age, string userEmail, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserEmail = userEmail;
            PhoneNumber = phoneNumber;
        }
    }
}