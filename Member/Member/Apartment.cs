using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM2
{
	class Apartment
	{
		public string Name { get; set; }
		public List<Member> Members;

		public Apartment()
		{
			Name = "N/A";
		}

		public Apartment(string name)
		{
			Name = name;
			Members = new List<Member>();
		}

		public void AddMember(Member member)
		{
			Members.Add(member);
		}

		public bool DeleteMemberByName(string memberNameToDelete)
		{
			var memberInList = Members.FirstOrDefault(a => a.FullName.Equals(memberNameToDelete));

			if (memberInList == null)
			{
				return false;
			}
			Members.Remove(memberInList);
			return true;
		}

		public bool UpdateMemberByFullName(string memberNameToUpdate,
			string newAddress, int newAge, int newPhoneNumber, int newRoom)
		{
			var memberInList = Members.FirstOrDefault(a => a.FullName.Equals(memberNameToUpdate));

			if (memberInList == null)
			{
				return false;
			}

			memberInList.Address = newAddress;
			memberInList.Age = newAge;
			memberInList.PhoneNumber = newPhoneNumber;
			memberInList.Room = newRoom;
			return true;
		}

		public void PrintMembers()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			if (!Members.Any())
			{
				Console.WriteLine("There is no member");
				return;
			}
			foreach (var member in Members)
			{
				Console.WriteLine(member.ToString());
				Console.WriteLine("=============");
			}
			Console.ResetColor();
		}

	}
}