using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class clsTestData
	{
		public struct stTest
		{
			public int TestID { get; set; }
			public int TestAppointmentID { get; set; }
			public bool TestResult { get; set; }
			public string Notes { get; set; }
			public int CreatedByUserID { get; set; }

			public stTest(
				int testID,
				int testAppointmentID,
				bool testResult,
				string notes,
				int createdByUserID)
			{
				TestID = testID;
				TestAppointmentID = testAppointmentID;
				TestResult = testResult;
				Notes = notes;
				CreatedByUserID = createdByUserID;
			}
		}

		public static DataTable getAllTests()
		{
			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Tests;";
			SqlCommand cmd = new SqlCommand(query, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
					dataTable.Load(reader);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"getAllTests: {ex.Message}");
				Console.ResetColor();
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		public static stTest getTestById(int id)
		{
			stTest test = new stTest();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Tests WHERE TestID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);
			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					reader.Read();
					test.TestID = reader.GetInt32(reader.GetOrdinal("TestID"));
					test.TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID"));
					test.TestResult = reader.GetBoolean(reader.GetOrdinal("TestResult"));
					test.Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
					test.CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
				}
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"getTestById: {ex.Message}");
				Console.ResetColor();
				test = default;
			}
			finally
			{
				connection.Close();
			}
			return test;
		}

		public static int addTest(stTest test)
		{
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"
                INSERT INTO Tests
                (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                VALUES
                (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
			cmd.Parameters.AddWithValue("@TestResult", test.TestResult);
			if (string.IsNullOrEmpty(test.Notes))
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Notes", test.Notes);
			cmd.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

			int testId = -1;

			try
			{
				connection.Open();
				object obj = cmd.ExecuteScalar();
				if (obj != null)
					int.TryParse(obj.ToString(), out testId);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"addTest: {ex.Message}");
				Console.ResetColor();
			}
			finally
			{
				connection.Close();
			}
			return testId;
		}

		public static bool updateTest(stTest test)
		{
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"
                UPDATE Tests
                SET
                    TestAppointmentID = @TestAppointmentID,
                    TestResult = @TestResult,
                    Notes = @Notes,
                    CreatedByUserID = @CreatedByUserID
                WHERE TestID = @TestID";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
			cmd.Parameters.AddWithValue("@TestResult", test.TestResult);
			if (string.IsNullOrEmpty(test.Notes))
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Notes", test.Notes);
			cmd.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);
			cmd.Parameters.AddWithValue("@TestID", test.TestID);

			bool success = false;

			try
			{
				connection.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
					success = true;
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"updateTest: {ex.Message}");
				Console.ResetColor();
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		public static bool deleteTestById(int id)
		{
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "DELETE FROM Tests WHERE TestID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);

			bool success = false;

			try
			{
				connection.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
					success = true;
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"deleteTest: {ex.Message}");
				Console.ResetColor();
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		// crud end

		public static int testsPassedCountPerLDLAId(int LDLAId)
		{
			clsSettings.log($"testsPassedCountPerLDLAId");

			string query = @"SELECT count(*) FROM     TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
				INNER JOIN LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
				where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAId and Tests.TestResult = 1";

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@LDLAId", LDLAId);

			int count = -1;

			try
			{
				connection.Open();
				count = (int)cmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"testsPassedCountPerLDLAId: {ex.Message}");
				count = -1;
			}
			finally
			{
				connection.Close();
			}

			return count;
		}
	}
}