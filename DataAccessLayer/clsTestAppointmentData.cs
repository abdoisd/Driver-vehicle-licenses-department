using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	static public class clsTestAppointmentData
	{
		public struct stTestAppointment
		{
			public int TestAppointmentID { get; set; }
			public int TestTypeID { get; set; }
			public int LocalDrivingLicenseApplicationID { get; set; }
			public DateTime TestDate { get; set; }
			public decimal PaidFees { get; set; }
			public int CreatedByUserID { get; set; }
			public bool IsLocked { get; set; }
			public int RetakeTestApplicationID { get; set; }

			public stTestAppointment(
				int testAppointmentID,
				int testTypeID,
				int localDrivingLicenseApplicationID,
				DateTime testDate,
				decimal paidFees,
				int createdByUserID,
				bool isLocked,
				int retakeTestApplicationID)
			{
				TestAppointmentID = testAppointmentID;
				TestTypeID = testTypeID;
				LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
				TestDate = testDate;
				PaidFees = paidFees;
				CreatedByUserID = createdByUserID;
				IsLocked = isLocked;
				RetakeTestApplicationID = retakeTestApplicationID;
			}
		}

		// view
		public static DataTable getAllTestAppointments()
		{
			clsUtils.log("getAllTestAppointments");

			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM TestAppointments_View_Me;";
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
				clsUtils.logError($"getAllTestAppointments: {ex.Message}");
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		public static stTestAppointment getTestAppointmentById(int id)
		{
			clsUtils.log("getTestAppointmentById");

			stTestAppointment appointment = new stTestAppointment();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);
			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					reader.Read();
					appointment.TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID"));
					appointment.TestTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
					appointment.LocalDrivingLicenseApplicationID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID"));
					appointment.TestDate = reader.GetDateTime(reader.GetOrdinal("TestDate"));
					appointment.PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
					appointment.CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
					appointment.IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked"));
					appointment.RetakeTestApplicationID = reader.IsDBNull(reader.GetOrdinal("RetakeTestApplicationID")) ? -1 : reader.GetInt32(reader.GetOrdinal("RetakeTestApplicationID"));
				}
			}
			catch (Exception ex)
			{
				clsUtils.logError($"getTestAppointmentById: {ex.Message}");
				appointment.TestAppointmentID = -1; // Indicate failure
			}
			finally
			{
				connection.Close();
			}
			return appointment;
		}

		public static int addTestAppointment(stTestAppointment appointment)
		{
			clsUtils.log("addTestAppointment");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"
                INSERT INTO TestAppointments
                (TestTypeID, LocalDrivingLicenseApplicationID, TestDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                VALUES
                (@TestTypeID, @LocalDrivingLicenseApplicationID, @TestDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                SELECT SCOPE_IDENTITY();";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
			cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
			cmd.Parameters.AddWithValue("@TestDate", appointment.TestDate);
			cmd.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
			cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);

			if (appointment.RetakeTestApplicationID == -1)
				cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@RetakeTestApplicationID", appointment.RetakeTestApplicationID);

			int appointmentId = -1;

			try
			{
				connection.Open();
				object obj = cmd.ExecuteScalar();
				if (obj != null)
					int.TryParse(obj.ToString(), out appointmentId);
			}
			catch (Exception ex)
			{
				clsUtils.logError($"addTestAppointment: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return appointmentId;
		}

		public static bool updateTestAppointment(stTestAppointment appointment)
		{
			clsUtils.log("updateTestAppointment");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"
                UPDATE TestAppointments
                SET
                    TestTypeID = @TestTypeID,
                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                    TestDate = @TestDate,
                    PaidFees = @PaidFees,
                    CreatedByUserID = @CreatedByUserID,
                    IsLocked = @IsLocked,
                    RetakeTestApplicationID = @RetakeTestApplicationID
                WHERE TestAppointmentID = @TestAppointmentID";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
			cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
			cmd.Parameters.AddWithValue("@TestDate", appointment.TestDate);
			cmd.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
			cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);
			if (appointment.RetakeTestApplicationID == -1)
				cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@RetakeTestApplicationID", appointment.RetakeTestApplicationID);
			cmd.Parameters.AddWithValue("@TestAppointmentID", appointment.TestAppointmentID);

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
				clsUtils.logError($"updateTestAppointment: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		public static bool deleteTestAppointmentById(int id)
		{
			clsUtils.log("deleteTestAppointmentById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @id";
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
				clsUtils.logError($"deleteTestAppointmentById: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		// get last test appointment of a test type
		// get all per test type
		// get test id

		public static DataTable getTestappointmentsPerLDLA(int LDLAID)
		{
			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"SELECT TestAppointmentID 
                     FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LDLAID";

			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

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
				Console.WriteLine($"getTestappointmentsPerLDLATestType: {ex.Message}");
				Console.ResetColor();
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		public static DataTable getTestappointmentsPerLDLATestType(int LDLAID, int TestTypeID)
		{
			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"SELECT TestAppointmentID, TestDate, PaidFees, IsLocked 
                     FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LDLAID AND TestTypeID = @TestTypeID";

			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@LDLAID", LDLAID);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
				Console.WriteLine($"getTestappointmentsPerLDLATestType: {ex.Message}");
				Console.ResetColor();
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		public static DataTable getTestAppointmentsPerTestTypeIsLockedLDLAID(int TestTypeID, bool IsLocked, int LDLAID)
		{
			clsUtils.log("getTestAppointmentsPerTestTypeIsLockedLDLAID");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"SELECT TestAppointments.TestAppointmentID, TestAppointments.TestTypeID, TestAppointments.IsLocked, LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
				FROM   TestAppointments 
				INNER JOIN LocalDrivingLicenseApplications 
				    ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
				WHERE TestTypeID = @TestTypeID AND IsLocked = @IsLocked AND LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAID";

			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
			cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
			cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

			DataTable dataTable = new DataTable();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
					dataTable.Load(reader);
			}
			catch (Exception ex)
			{
				clsUtils.logError($"getTestAppointmentsPerTestTypeIsLockedLDLAID: {ex.Message}");
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}
	}
}
