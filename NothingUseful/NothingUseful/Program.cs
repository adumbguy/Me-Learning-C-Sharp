using System;
using NothingUseful;

namespace NothingUseful
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome! Here is my useless program 2.0!");
			Console.WriteLine ("It's only 2.0 because it's writen in C# instead of Java.");
			Console.WriteLine ("Anyways, I planned on saving most of my learning in this project!");
			Console.WriteLine ("Oh, and don't expect it to look pretty either, I'm not super awesome at this yet.");
			Console.WriteLine ("");
			Console.WriteLine ("Here we have a choice of two programs [1. MathStuffs] or [2. FileMania]");
			Console.WriteLine ("Just type the number of the one you want to run");
			Console.Write ("Take your pick : ");
			bool valid = false;
			while (valid == false) {
				string choice = Console.ReadLine ();

				switch (choice) {
				case "1":
					valid = true;
					MathStuffs.Stuff ();
					break;
				case "2":
					valid = true;
					FileMan.FileMania ();

					break;
				default:
					Console.WriteLine ("Come on man, I gave you the only choices");
					break;
				}
			}

			//FileMan.FileMania ();
			//MathStuffs.Stuff ();
		}
	}
}
