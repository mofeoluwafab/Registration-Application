using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.model
{
	public class Address
	{
		public string Street;
		public string City;
		public string State;
		public int ZipCode;
		public string  UserEmail;

        public Address(string street, string city, string state , int zipCode , string userEmail )
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            UserEmail = userEmail;
        }

    }
}