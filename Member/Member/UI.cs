using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM2
{
	class UI
	{
		public static void ShowOptions()
		{

			Console.Clear();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1: Add Member");
			Console.WriteLine("2: Print Members List");
			Console.WriteLine("3: Remove Members by Name");
			Console.WriteLine("4: Update Members Information");
			Console.WriteLine("5: Quit");
			Console.ResetColor();
		}

		public static void ShowMenu()
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("**************************************");
			Console.WriteLine("*****Welcome To Sinh's Apartments*****");
			Console.WriteLine("**************************************");
			Console.ResetColor();
		}



		public static string EnterMemberName()
		{
			Console.Write("Enter Member Name: ");
			return Console.ReadLine();
		}

		public static string EnterMemberAddress()
		{
			Console.Write("Enter Member Address: ");
			return Console.ReadLine();
		}

		public static int EnterMemberAge()
		{
			Console.Write("Enter Member Age: ");
			return int.Parse(Console.ReadLine());
		}
		public static int MemberPhoneNumber()
		{
			Console.Write("Enter Member Phone Number: ");
			return int.Parse(Console.ReadLine());
		}
		public static int MemberRoom()
		{
			Console.Write("Enter Member Room: ");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterApartmentName()
		{
			Console.Write("Enter Admin Name: ");
			return Console.ReadLine();
		}

		public static string EnterCommand()
		{
			Console.Write("Enter Command: ");
			return Console.ReadLine();
		}
		public static void ContinueOrNot(Apartment uni)
		{
			while (true)
			{
				Console.WriteLine("Enter A to Add more or Enter B to cancel!");
				string choice = Console.ReadLine();
				if (choice == "A")
				{
					uni.AddMember(new Member(
						UI.EnterMemberName(),
						UI.EnterMemberAddress(),
						UI.EnterMemberAge(),
						UI.MemberPhoneNumber(),
						UI.MemberRoom())
					);
				}
				else if (choice == "B")
				{
					break;
				}
			}


		}

		public static void EnterToContinue()
		{
			Console.WriteLine("Enter to Continue");
			Console.ReadLine();
		}

		public static void SucceedMessage()
		{
			Console.WriteLine("SUCCED!");
		}

		public static void FailedMessage()
		{
			Console.WriteLine("FAILED!");
		}
	}
}