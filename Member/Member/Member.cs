using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM2
{
	class Member
	{
		public int Age;
		public int PhoneNumber;
		public int Room;
		public string FullName { get; set; }
		public string Address { get; set; }
		public Member()
		{
			Age = 0;
			FullName = "N/A";
			Address = "N/A";
			PhoneNumber = 0;
			Room = 0;

		}

		public Member(string fullName, string address, int age, int phoneNumber, int room)
		{
			FullName = fullName;
			Address = address;
			Age = age;
			PhoneNumber = phoneNumber;
			Room = room;
		}

		public string ToString()
		{
			string result =
				$"Member Full Name: {FullName} \n" +
				$"Age: {Age} \n" +
				$"Address: {Address} \n" +
				$"PhoneNumber: {PhoneNumber} \n" +
				$"Room: {Room}";

			return result;
		}
	}
}