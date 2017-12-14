using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Data types
			start: int @int = 2147483647;
			short @short = 32767;
			long @long = 100000000000000000;
			byte @byte = 255;

			float @float = 1.21321f; 
			double @double = 1.2312123; 
			decimal @decimal = 1122.123M; 

			bool @bool = true;
			char @char = 'x';

			string intro = "hello world"; //Programming tradition when being introduced to new languages

			Console.WriteLine(intro);
			Console.WriteLine(+@float +" " +@int +" " + @long +" " + @short +" " + @byte +" " +@double +" " +@decimal + " " +@bool + " " +@char); // yep we went there

			Console.WriteLine("--------------------------"); 
			Console.WriteLine("IF, ELSE, & ELSE IF ");
			if (intro.Length > 0)
			{
				Console.WriteLine("string length is > 0");
			}
			else
			{
				Console.WriteLine("String length is < 0");
			}

			Console.WriteLine("--------------------------");
			Console.WriteLine("SWITCH & CASE: ");

			int x, y;
			Console.WriteLine("Enter two Integers");
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());
			Console.WriteLine("Operations");
			Console.WriteLine("1= Add\n2= Subtract \n3= Multiply");
			Console.Write("Enter the operation code:: ");
			int op = int.Parse(Console.ReadLine());

			switch (op)
			{
				case 1:
					Console.WriteLine("Sum=" +(x+y));
					break;
				case 2:
					Console.WriteLine("Difference = " +(x-y));
					break;
				case 3:
					Console.WriteLine("Product = " +(x*y));
					break;
			}

			Console.WriteLine("--------------------------");
			Console.WriteLine("For loop: ");

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(intro +" " +(i+1));
			}
			Console.WriteLine("--------------------------");
			Console.WriteLine("Foreach loop: ");
			
			string[] names = {"Lester","Marionne","Angelo","Noreen","Niks"};
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("--------------------------");
			Console.WriteLine("while loop: ");
			int count = 0;
			while (count < 10)
			{
				Console.WriteLine("The value in the counter is " +count);
				count++;
			}

			Console.WriteLine("--------------------------");
			Console.WriteLine("do while loop: ");
			count = 0;
			do
			{
				Console.WriteLine("The value in the counter is" +count);
				count++;
			} while (count < 10);
			goto start;
		}
	}
}
