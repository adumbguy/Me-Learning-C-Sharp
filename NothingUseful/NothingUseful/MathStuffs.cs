using System;

namespace NothingUseful
{
	public class MathStuffs
	{
		public static void Stuff ()
		{

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

			Console.WriteLine ("");
			Console.Write ("Press ENTER to go onto multiplication!");
			Console.ReadLine ();

			valid = false;
			int x3 = 0;
			int y3 = 0;
			Console.WriteLine ("Gotta to the good ol' X and Y again.");
			while (valid == false) {
				Console.Write ("Enter X : ");
				if (int.TryParse (Console.ReadLine (), out x3)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number.");
				}
			}
			valid = false;
			while (valid == false) {
				Console.WriteLine ("Enter Y : ");
				if (int.TryParse (Console.ReadLine (), out y3)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number");
				}
			}
			int z3 = x3 * y3;
			Console.WriteLine (x3.ToString () + " x " + y3.ToString () + " = " + z3.ToString ());

			Console.WriteLine ();
			Console.WriteLine ("Last but not least dividing! PRESS ENTER ALREADY!");
			Console.ReadLine ();

			valid = false;
			int x4 = 0;
			int y4 = 0;
			Console.WriteLine ("Again with X's and the Y's... Yeesh.");
			while (valid == false) {
				Console.Write ("Enter X : ");
				if (int.TryParse (Console.ReadLine (), out x4)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number");
				}
			}
			valid = false;
			while (valid == false) {
				Console.Write ("Enter Y : ");
				if (int.TryParse (Console.ReadLine (), out y4)) {
					valid = true;
				} else {
					Console.WriteLine ("Please enter a valid number");
				}
			}
			int z4 = x4 / y4;
			Console.WriteLine(x4.ToString() + " / " + y4.ToString() + " = " + z4.ToString());

			Console.Write ("END");
			Console.Read();
		}
	}
}

