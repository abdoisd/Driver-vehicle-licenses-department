using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	static public class clsLocalDrivingLicenseApplicationData
	{
		public struct stLocalDrivingLicenseApplicationData
		{
			public int LocalDrivingLicenseApplicationID { get; set; }
			public int ApplicationID { get; set; }
			public int LicenseClassID { get; set; }
			public stLocalDrivingLicenseApplicationData(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
			{
				LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
				ApplicationID = applicationID;
				LicenseClassID = licenseClassID;
			}
		}

		static public DataTable getLocalDrivingLicenseView()
		{
			clsSettings.log("getLocalDrivingLicenseView");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from LocalDrivingLicenseApplications_View";
			SqlCommand command = new SqlCommand(query, connection);

			DataTable dataTable = new DataTable();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				dataTable.Load(reader);
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getLocalDrivingLicenseView: {ex.Message}");
				connection.Close();
				return null;
			}

			return dataTable;
		}

		static public stLocalDrivingLicenseApplicationData getLocalDrivingLicenseApplicationById(int id)
		{
			clsSettings.log("getLocalDrivingLicenseApplicationById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", id);

			stLocalDrivingLicenseApplicationData localDrivingLicenseApplicationData = new stLocalDrivingLicenseApplicationData();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					localDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID = reader.GetInt32(0);
					localDrivingLicenseApplicationData.ApplicationID = reader.GetInt32(1);
					localDrivingLicenseApplicationData.LicenseClassID = reader.GetInt32(2);
				}
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getLocalDrivingLicenseApplicationById: {ex.Message}");
				connection.Close();
				localDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID = -1;
			}

			return localDrivingLicenseApplicationData;
		}

		static public int addLocalDrivingLicenseApplication(stLocalDrivingLicenseApplicationData localDrivingLicenseApplicationData) // return id
		{
			clsSettings.log("addLocalDrivingLicenseApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "insert into LocalDrivingLicenseApplications " +
				"(ApplicationID, LicenseClassID) values (@applicationID, @licenseClassID); select scope_identity();";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@applicationID", localDrivingLicenseApplicationData.ApplicationID);
			command.Parameters.AddWithValue("@licenseClassID", localDrivingLicenseApplicationData.LicenseClassID);

			int newId = -1;

			try
			{
				connection.Open();
				newId = (int)(decimal)command.ExecuteScalar();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"addLocalDrivingLicenseApplication: {ex.Message}");
				connection.Close();
			}

			return newId;
		}

		static public bool updateLocalDrivingLicenseApplication(stLocalDrivingLicenseApplicationData localDrivingLicenseApplicationData)
		{
			clsSettings.log("updateLocalDrivingLicenseApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "update LocalDrivingLicenseApplications set ApplicationID = @applicationID, " +
				"LicenseClassID = @licenseClassID where LocalDrivingLicenseApplicationID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", localDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue("@applicationID", localDrivingLicenseApplicationData.ApplicationID);
			command.Parameters.AddWithValue("@licenseClassID", localDrivingLicenseApplicationData.LicenseClassID);

			bool isUpdated = false;

			try
			{
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				isUpdated = (rowsAffected > 0);
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"updateLocalDrivingLicenseApplication: {ex.Message}");
				connection.Close();
			}

			return isUpdated;
		}

		static public bool deleteLocalDrivingLicenseApplication(int id)
		{
			clsSettings.log("deleteLocalDrivingLicenseApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", id);

			bool isDeleted = false;

			try
			{
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				isDeleted = (rowsAffected > 0);
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"deleteLocalDrivingLicenseApplication: {ex.Message}");
				connection.Close();
			}

			return isDeleted;
		}

		// crud end

		static public DataTable getLDLAPerLicenseClassIDPersonIDApplicationStatus(int LicenseClassID, int PersonID, Byte ApplicationStatus)
		{
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicantPersonID, Applications.ApplicationStatus
                FROM   LocalDrivingLicenseApplications INNER JOIN
                Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE LicenseClassID = @LicenseClassID AND ApplicantPersonID = @ApplicantPersonID AND ApplicationStatus = @ApplicationStatus";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
			command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
			command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

			DataTable dataTable = new DataTable();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				dataTable.Load(reader);
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getLDLAPerLicenseClassIDPersonIDApplicationStatus: {ex.Message}");
				connection.Close();
				return null;
			}

			return dataTable;
		}
	}
}
