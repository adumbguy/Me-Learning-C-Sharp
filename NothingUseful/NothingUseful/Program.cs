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
			Console.Write ("Press ENTER to get on with it...");
			Console.ReadLine();

			MathStuffs.Stuff ();
		}
	}
}
