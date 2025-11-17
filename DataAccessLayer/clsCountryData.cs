using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class clsCountryData
	{
		static private string connectionString = "Server=.;DataBase=DVLD;User Id=sa;Password=sa123456;";

		public struct stCountry
		{
			public int CountryId { get; set; }
			public string CountryName { get; set; }
		}

		public static DataTable getAllCountries()
		{
			SqlConnection connection = new SqlConnection(connectionString);
			string query = "select * from Countries;";
			SqlCommand cmd = new SqlCommand(query, connection);

			DataTable dataTable = new DataTable();

			try
			{
				connection.Open();
				SqlDataReader dataReader = cmd.ExecuteReader();
				dataTable.Load(dataReader);
				dataReader.Close();
			}
			catch (Exception ex)
			{
				connection.Close();
			}
			connection.Close();

			return dataTable;
		}

		public static stCountry getCountryByID(int id)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("getCountryByID");
			Console.ResetColor();

			SqlConnection connection = new SqlConnection(connectionString);
			string query = "select * from Countries where CountryID = @id;";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);
			stCountry country = new stCountry();

			try
			{
				connection.Open();
				SqlDataReader dataReader = cmd.ExecuteReader();

				dataReader.Read();
				country.CountryId = (int)dataReader[0];
				country.CountryName = (string)dataReader[1];

				dataReader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"getCountryByID: {ex.Message}");
				Console.ResetColor();

				connection.Close();
				country.CountryId = -1;
			}

			return country;
		}
	}
}
