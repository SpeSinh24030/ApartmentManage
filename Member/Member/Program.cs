using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM2
{
	class Program
	{
		static void Main(string[] args)
		{
			UI.ShowMenu();

			var uni = new Apartment(UI.EnterApartmentName());

			UI.ShowOptions();

			string command = Command.INIT;

			while (command != Command.EXIT)
			{
				command = UI.EnterCommand();

				switch (command)
				{

					case Command.ADD_MEMBER:
						uni.AddMember(new Member(
								UI.EnterMemberName(),
								UI.EnterMemberAddress(),
								UI.EnterMemberAge(),
								UI.MemberPhoneNumber(),
								UI.MemberRoom())
							);
						UI.ContinueOrNot(uni);
						UI.ShowOptions();


						break;


					case Command.PRINT_MEMBERS:
						uni.PrintMembers();

						UI.EnterToContinue();
						UI.ShowOptions();

						break;


					case Command.REMOVE_MEMBER:
						var memberNameToDelete = UI.EnterMemberName();
						if (uni.DeleteMemberByName(memberNameToDelete))
						{
							UI.SucceedMessage();
						}

						else
						{
							UI.FailedMessage();
						}

						UI.ShowOptions();

						break;


					case Command.UPDATE_MEMBER:
						var memberNameToUpdate = UI.EnterMemberName();
						var newPhoneNumber = UI.MemberPhoneNumber();
						var newAddress = UI.EnterMemberAddress();
						var newAge = UI.EnterMemberAge();
						var newRoom = UI.MemberRoom();

						if (uni.UpdateMemberByFullName(memberNameToUpdate, newAddress, newAge, newPhoneNumber, newRoom))
						{
							UI.SucceedMessage();
						}
						else
						{
							UI.FailedMessage();
						}

						UI.ShowOptions();
						break;


					case Command.EXIT:
						return;

					default:
						Console.WriteLine("Invalid Command");
						break;
				}
			}
		}
	}
}