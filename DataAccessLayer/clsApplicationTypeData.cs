using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	static public class clsApplicationTypeData
	{

		public struct stApplicationType
		{
			public int ApplicationTypeID { get; set; }
			public string ApplicationTypeTitle { get; set; }
			public decimal ApplicationFees { get; set; }
			public stApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
			{
				ApplicationTypeID = applicationTypeID;
				ApplicationTypeTitle = applicationTypeTitle;
				ApplicationFees = applicationFees;
			}
		}

		static public DataTable getAllApplicationTypes()
		{
			clsSettings.log("getAllApplicationTypes");

			DataTable dt = new DataTable();

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from ApplicationTypes;";
			SqlCommand cmd = new SqlCommand(query, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
					dt.Load(reader);
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getAllApplicationTypes: {ex.Message}");
				dt = null;
			}
			finally
			{
				connection.Close();
			}

			return dt;
		}

		static public stApplicationType getApplicationTypeById(int id)
		{
			clsSettings.log($"getApplicationTypeById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID;";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@ApplicationTypeID", id);

			stApplicationType applicationType = new stApplicationType();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					reader.Read();
					applicationType.ApplicationTypeID = (int)reader[0];
					applicationType.ApplicationTypeTitle = (string)reader[1];
					applicationType.ApplicationFees = (decimal)reader[2];
				}
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getApplicationTypeById: {ex.Message}");
				applicationType.ApplicationTypeID = -1;
			}
			finally
			{
				connection.Close();
			}
			return applicationType;
		}

		static public bool updateApplicationType(stApplicationType applicationType)
		{
			clsSettings.log("updateApplicationType");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"update ApplicationTypes set ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees
				where ApplicationTypeID = @ApplicationTypeID;";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationType.ApplicationTypeID);
			cmd.Parameters.AddWithValue("@ApplicationTypeTitle", applicationType.ApplicationTypeTitle);
			cmd.Parameters.AddWithValue("@ApplicationFees", applicationType.ApplicationFees);

			try
			{
				connection.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
			catch (Exception ex)
			{
				clsSettings.logError($"updateApplicationType: {ex.Message}");
				return false;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
