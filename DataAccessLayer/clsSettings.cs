using System;

namespace DataAccessLayer
{
	static public class clsSettings
	{
		static public string connectionString = "Server=.;DataBase=DVLD;User Id=sa;Password=sa123456;";

		static public void log(string msg)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(msg);
			Console.ResetColor();
		}

		static public  void logError(string msg)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(msg);
			Console.ResetColor();
		}
	}
}
