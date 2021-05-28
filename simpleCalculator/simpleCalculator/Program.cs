using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
	class Program
	{
		public static double num1, num2;
		public static double addi, subt, mult, divi, mod;
		static void Main(string[] args)
		{
			string programName = "\t\tMINI CALCULATOR";

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n--------------------------------------------------");
			Console.WriteLine(programName);
			Console.WriteLine("Note for this version: Select operand unavailable.");
			Console.WriteLine("--------------------------------------------------\n");

			Console.WriteLine("\n===============Your Input===============");
			Console.WriteLine("Enter the first number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the second number: ");
			num2 = Convert.ToDouble(Console.ReadLine());

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("===============Result Out===============\n");
			//Console.ReadLine();
			// call methods & // output result
			addi = add(num1, num2);
			Console.WriteLine(addi);
			
			subt = subtract(num1, num2);
			Console.WriteLine(subt);
			
			mult = multiply(num1, num2);
			Console.WriteLine(mult);
			
			divi = divide(num1, num2);
			Console.WriteLine(divi);

			mod = modulo(num1, num2);
			Console.WriteLine(mod);

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n===============Terminated===============\n");
			Console.WriteLine("\nPress any key to quit..");
			Console.ReadKey();

			

		}

		// method add
		public static double add(double x, double y)
		{
			double result = x + y;
			Console.Write("Sum = ");
			return result;
		}
		// method subtract
		public static double subtract(double x, double y)
		{
			double result = x - y;
			Console.Write("Difference = ");
			return result;
		}
		// method multiply
		public static double multiply(double x, double y)
		{
			double result = x * y;
			Console.Write("Product = ");
			return result;
		}
		// method divide
		public static double divide(double x, double y)
		{
			double result = x / y;
			Console.Write("Quotient = ");
			return result;
		}
		// method modulo => rest of division
		public static double modulo(double x, double y)
		{
			double result = x % y;
			Console.Write("Rest of division = ");
			return result;
		}

	}
}
