using System;

namespace NothingUseful
{
	public class MathStuffs
	{
		public static void Stuff ()
		{
			Console.SetWindowSize (400, 400);
			Console.WriteLine ();
			Console.WriteLine ("Hello and welcome to MathStuffs!");
			Console.WriteLine ("It's alot like what it sounds, lets get started!");

			Console.WriteLine ("First, adding. Enter a number for x and y when prompted.");

			int x1 = 0;
			int y1 = 0;
			bool valid = false;

			while (valid == false) {
				Console.Write ("Please enter a number for X : ");
				if (int.TryParse (Console.ReadLine (), out x1)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number.");
				}
			}

			valid = false;

			while (valid == false) {
				Console.Write ("Now enter a number for Y : ");
				if (int.TryParse (Console.ReadLine (), out y1)) {
					valid = true;
				}else{
					Console.WriteLine ("Please enter a valid number.");
				}
			}
				int z1 = x1 + y1;
			
			Console.WriteLine ("Okay, so " + x1.ToString() + " + " + y1.ToString() + " = " + z1.ToString());

			Console.WriteLine ();
			Console.Write ("Awesome! Now press ENTER to go onto subtracting!");
			Console.ReadLine ();
			Console.WriteLine ();

			valid = false;
			int x2 = 0;
			int y2 = 0;

			Console.WriteLine ("Let's do that same thing as adding, enter a value for x and y.");
			while(valid == false){
				Console.Write ("Enter an X value : ");
				if(int.TryParse(Console.ReadLine(), out x2)){
					valid = true;
				}else{
					Console.WriteLine ("Please enter a valid number.");
				}
			}

			valid = false;

			while (valid == false) {
				Console.Write ("Now a value for Y : ");
				if (int.TryParse (Console.ReadLine (), out y2)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number.");
				}
			}
			int z2 = x2 - y2;
			Console.WriteLine("And " + x2.ToString() + " - " + y2.ToString() + " = " +z2.ToString());

			Console.Write ("END");
			Console.Read();
		}
	}
}

