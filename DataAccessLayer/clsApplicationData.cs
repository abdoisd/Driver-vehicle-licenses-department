using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	static public class clsApplicationData
	{
		public struct stApplication
		{
			public int ApplicationID { get; set; }
			public int ApplicantPersonID { get; set; }
			public DateTime ApplicationDate { get; set; }
			public int ApplicationTypeID { get; set; }
			public Byte ApplicationStatus { get; set; }
			public DateTime LastStatusDate { get; set; }
			public decimal PaidFees { get; set; }
			public int CreatedByUserID { get; set; }
		}

		static public DataTable getAllApplications()
		{

			clsSettings.log("getAllApplications");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from Applications";
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
				clsSettings.logError($"getAllApplications: {ex.Message}");
				connection.Close();
				return null;
			}

			return dataTable;
		}

		static public stApplication getApplicationById(int id)
		{
			clsSettings.log("getApplicationById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from Applications where ApplicationID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", id);

			stApplication application = new stApplication();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					application.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
					application.ApplicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID"));
					application.ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
					application.ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID"));
					application.ApplicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus"));
					application.LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
					application.PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
					application.CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
				}
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getApplicationById: {ex.Message}");
				connection.Close();
				application.ApplicationID = -1;
			}

			return application;
		}

		static public int addApplication(stApplication application) // return id
		{
			clsSettings.log("addApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "insert into Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) " +
				"values (@applicantPersonID, @applicationDate, @applicationTypeID, @applicationStatus, @lastStatusDate, @paidFees, @createdByUserID); select scope_identity();";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@applicantPersonID", application.ApplicantPersonID);
			command.Parameters.AddWithValue("@applicationDate", application.ApplicationDate);
			command.Parameters.AddWithValue("@applicationTypeID", application.ApplicationTypeID);
			command.Parameters.AddWithValue("@applicationStatus", application.ApplicationStatus);
			command.Parameters.AddWithValue("@lastStatusDate", application.LastStatusDate);
			command.Parameters.AddWithValue("@paidFees", application.PaidFees);
			command.Parameters.AddWithValue("@createdByUserID", application.CreatedByUserID);

			int newId = -1;

			try
			{
				connection.Open();
				object result = command.ExecuteScalar();
				if (result != null && int.TryParse(result.ToString(), out int id))
					newId = id;
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"addApplication: {ex.Message}");
				connection.Close();
			}

			application.ApplicationID = newId;
			return newId;
		}

		static public bool updateApplication(stApplication application)
		{
			clsSettings.log("updateApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "update Applications set ApplicantPersonID = @applicantPersonID, ApplicationDate = @applicationDate, " +
				"ApplicationTypeID = @applicationTypeID, ApplicationStatus = @applicationStatus, LastStatusDate = @lastStatusDate, " +
				"PaidFees = @paidFees, CreatedByUserID = @createdByUserID where ApplicationID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", application.ApplicationID);
			command.Parameters.AddWithValue("@applicantPersonID", application.ApplicantPersonID);
			command.Parameters.AddWithValue("@applicationDate", application.ApplicationDate);
			command.Parameters.AddWithValue("@applicationTypeID", application.ApplicationTypeID);
			command.Parameters.AddWithValue("@applicationStatus", application.ApplicationStatus);
			command.Parameters.AddWithValue("@lastStatusDate", application.LastStatusDate);
			command.Parameters.AddWithValue("@paidFees", application.PaidFees);
			command.Parameters.AddWithValue("@createdByUserID", application.CreatedByUserID);

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
				clsSettings.logError($"updateApplication: {ex.Message}");
				connection.Close();
			}

			return isUpdated;
		}

		static public bool deleteApplication(int id)
		{
			clsSettings.log("deleteApplication");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "delete from Applications where ApplicationID = @id";
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
				clsSettings.logError($"deleteApplication: {ex.Message}");
				connection.Close();
			}

			return isDeleted;
		}
	}
}
