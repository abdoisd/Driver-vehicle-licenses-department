using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class clsTestTypeData
	{
		public struct stTestType
		{
			public int TestTypeID { get; set; }
			public string TestTypeTitle { get; set; }
			public string TestTypeDescription { get; set; }
			public decimal TestTypeFees { get; set; }
			public stTestType(
				int testTypeID,
				string testTypeTitle,
				string testTypeDescription,
				decimal testTypeFees)
			{
				TestTypeID = testTypeID;
				TestTypeTitle = testTypeTitle;
				TestTypeDescription = testTypeDescription;
				TestTypeFees = testTypeFees;
			}
		}

		static public DataTable getAllTestTypes()
		{
			using (SqlConnection connection = new SqlConnection(clsSettings.connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand("SELECT * FROM TestTypes", connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						return dataTable;
					}
				}
			}
		}

		public static stTestType getTestTypeById(int testTypeID)
		{
			using (SqlConnection connection = new SqlConnection(clsSettings.connectionString))
			{
				connection.Open();
				string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@TestTypeID", testTypeID);
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							return new stTestType(
								testTypeID,
								reader["TestTypeTitle"].ToString(),
								reader["TestTypeDescription"].ToString(),
								(decimal)reader["TestTypeFees"]);
						}
					}
				}
			}
			stTestType notFound = new stTestType();
			notFound.TestTypeID = -1;
			return notFound;
		}

		static public bool updateTestType(stTestType testType)
		{
			using (SqlConnection connection = new SqlConnection(clsSettings.connectionString))
			{
				connection.Open();
				string query = "UPDATE TestTypes SET TestTypeTitle = @TestTypeTitle, " +
							   "TestTypeDescription = @TestTypeDescription, " +
							   "TestTypeFees = @TestTypeFees WHERE TestTypeID = @TestTypeID";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@TestTypeID", testType.TestTypeID);
					command.Parameters.AddWithValue("@TestTypeTitle", testType.TestTypeTitle);
					command.Parameters.AddWithValue("@TestTypeDescription", testType.TestTypeDescription);
					command.Parameters.AddWithValue("@TestTypeFees", testType.TestTypeFees);
					return command.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
