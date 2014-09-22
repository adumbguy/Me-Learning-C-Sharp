using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace NothingUseful
{
	public class FileMan
	{
		public static void FileMania ()
		{
			string textsPath = @"C:\Users\Eddie\Documents\Projects\itsHappening\Me-Learning-C-\NothingUseful\NothingUseful\TextFiles";
			Console.WriteLine ("Welcome! Here you can write text to a file! The code is VERY sloppy.");
			Console.WriteLine ("So yeah, it aint pretty. Regardless, here we go!");
			Console.Write ("What file do you wanna write? (Don't type the extension) : ");
			string fileName = Console.ReadLine() + ".txt";
			string filePath = System.IO.Path.Combine (textsPath, fileName);
			StringBuilder sb = new StringBuilder ();
			bool writing = true;
			bool finished = false;
			bool overWrite = false;
			Console.WriteLine ("Writing {0} to {1} ", fileName, filePath);
			while (writing == true) {
				if (!System.IO.File.Exists (filePath) | overWrite == true) {
					using (System.IO.FileStream fs = System.IO.File.Create (filePath)) {

					}
					bool gettingInput = true;
					List<string> text = new List<string>();
					Console.WriteLine ("Currently writing to {0} : ", fileName);
					Console.WriteLine ("Type '/exit' to finish and save the file");
					int x = 1;
					while(gettingInput == true){
						Console.Write ("Ln " + x.ToString () + " : ");
						string outText = Console.ReadLine ();
						if (outText.Equals ("/exit")) {
							gettingInput = false;
							break;
						} else {
							text.Add (outText);
							x++;
						}
					}
					System.IO.File.WriteAllLines (filePath, text);
					finished = true;
				} else {
					Console.WriteLine ("File \" {0} \" already exists.", fileName);
					Console.Write ("Would you like to overwrite it? : ");
					int end = 0;
					while (end < 1) {
						var yn = Console.ReadKey ();
						switch (yn.Key) {
						case ConsoleKey.Y:
							overWrite = true;
							end++;
							break;
						case ConsoleKey.N:
							Console.WriteLine ();
							Console.WriteLine (" Operation cancled, press any key to exit");
							Console.ReadKey ();
							return;
							break;
						default:
							Console.WriteLine (" Please use either y or n.");
							break;
						}
					}
				}
				if (overWrite == false) {
				
				} else {
					Console.WriteLine ();
					Console.WriteLine ("Overwriting {0}", fileName);
				}
				if (finished == true) {
					writing = false;
				}
			}

			try{
				string[] readBuffer = System.IO.File.ReadAllLines(filePath);
				Console.WriteLine("Printing {0} : ", fileName);
				foreach (string b in readBuffer){
					Console.Write(b + Environment.NewLine);
				}
				Console.WriteLine();
			}catch (System.IO.IOException e){
				Console.WriteLine (e.Message);
			}
			Console.WriteLine ("Press any key to continue");
			Console.ReadKey ();
		}
	}
}

