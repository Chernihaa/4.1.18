using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1._18
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

			var color = Console.ReadLine();

			switch (color)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Вы выбрали красный цвет");
					Console.ReadLine();
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Вы выбрали зеленый цвет");
					Console.ReadLine();
					break;

				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Вы выбрали голубой цвет");
					Console.ReadLine();
					break;

				default:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("Вы выбрали цвет по default - это желтый");
					Console.ReadLine();
					break;
			}
		}
    }
}
