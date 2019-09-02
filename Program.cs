using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());

			int cakeParts = width * height;
			int takenParts = 0;
			int takenPartsSum = 0;

			string command = Console.ReadLine();
			command = command.ToLower();

			if (command == "stop")
			{
				Console.WriteLine($"{cakeParts} pieces are left.");
			}
			else
			{


				while (command != "stop" || cakeParts == takenPartsSum)
				{
					// int newTakenparts = int.Parse(Console.ReadLine());
					

					if (command == "stop" && (cakeParts > takenPartsSum))
					{
						Console.WriteLine($"{cakeParts - takenPartsSum} pieces are left.");
						break;
					}
					else
					{

						takenParts = int.Parse(command);
						takenPartsSum += takenParts;

						if (takenPartsSum > cakeParts) // според мен трябва да има и = защото този случай обхваща всичко което е различно от 
						//	"ако стигнете до STOP и не са свършили парчетата торта". Т.е. парчетата трябва да са свършили или да са на "-"
						{

							Console.WriteLine($"No more cake left! You need {takenPartsSum - cakeParts} pieces more.");
							break;
						}

					}

					command = Console.ReadLine();
					command = command.ToLower();


				}

				if (takenPartsSum < cakeParts)
				{
					Console.WriteLine($"{cakeParts - takenPartsSum} pieces are left.");
				}



			}

			
		}
	}
}
