using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using static DataAccessLayer.clsLicenseData;

namespace DataAccessLayer
{
	public class clsLicenseData
	{
		public struct stLicense
		{
			public int LicenseID { get; set; }
			public int ApplicationID { get; set; }
			public int DriverID { get; set; }
			public int LicenseClassID { get; set; }
			public DateTime IssueDate { get; set; }
			public DateTime ExpirationDate { get; set; }
			public string Notes { get; set; }
			public decimal PaidFees { get; set; }
			public bool IsActive { get; set; }
			public Byte IssueReason { get; set; }
			public int CreatedByUserID { get; set; }

			public stLicense(
				int licenseID, int applicationID, int driverID, int licenseClassID,
				DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees,
				bool isActive, Byte issueReason, int createdByUserID)
			{
				LicenseID = licenseID;
				ApplicationID = applicationID;
				DriverID = driverID;
				LicenseClassID = licenseClassID;
				IssueDate = issueDate;
				ExpirationDate = expirationDate;
				Notes = notes;
				PaidFees = paidFees;
				IsActive = isActive;
				IssueReason = issueReason;
				CreatedByUserID = createdByUserID;
			}
		}

		public static DataTable getAllLicenses()
		{
			clsUtils.log("getAllLicenses");

			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Licenses;";
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
				clsUtils.logError("getAllLicenses: " + ex.Message);
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		public static stLicense getLicenseByID(int id)
		{
			clsUtils.log("getLicenseByID");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Licenses WHERE LicenseID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);

			stLicense license = new stLicense();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					license = new stLicense(
						(int)reader["LicenseID"],
						(int)reader["ApplicationID"],
						(int)reader["DriverID"],
						(int)reader["LicenseClassID"],
						(DateTime)reader["IssueDate"],
						(DateTime)reader["ExpirationDate"],
						reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"],
						(decimal)reader["PaidFees"],
						(bool)reader["IsActive"],
						(Byte)reader["IssueReason"],
						(int)reader["CreatedByUserID"]
					);
				}
				else
					throw new Exception("License Not Found");
				reader.Close();
			}
			catch (Exception ex)
			{
				clsUtils.logError("getLicenseByID: " + ex.Message);
				license.LicenseID = -1;
			}
			finally
			{
				connection.Close();
			}
			return license;
		}

		public static stLicense getLicenseByLDLA(int LDLAId)
		{
			clsUtils.log("getLicenseByLDLA");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT Licenses.LicenseID,  Licenses.ApplicationID,    Licenses.DriverID,    Licenses.LicenseClassID," +
				"     Licenses.IssueDate, Licenses.ExpirationDate,   Licenses.Notes, Licenses.PaidFees,  Licenses.IsActive, Licenses.IssueReason, " +
				" Licenses.CreatedByUserID FROM Applications INNER JOIN LocalDrivingLicenseApplications" +
				" ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN Licenses" +
				" ON Applications.ApplicationID = Licenses.ApplicationID where LocalDrivingLicenseApplicationID = @LDLAId";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@LDLAId", LDLAId);

			stLicense license = new stLicense();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					license = new stLicense(
						(int)reader["LicenseID"],
						(int)reader["ApplicationID"],
						(int)reader["DriverID"],
						(int)reader["LicenseClassID"],
						(DateTime)reader["IssueDate"],
						(DateTime)reader["ExpirationDate"],
						reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"],
						(decimal)reader["PaidFees"],
						(bool)reader["IsActive"],
						(Byte)reader["IssueReason"],
						(int)reader["CreatedByUserID"]
					);
				}
				else
					throw new Exception("License Not Found");
				reader.Close();
			}
			catch (Exception ex)
			{
				clsUtils.logError("getLicenseByLDLA: " + ex.Message);
				license.LicenseID = -1;
			}
			finally
			{
				connection.Close();
			}
			return license;
		}

		public static int addLicense(stLicense license)
		{
			clsUtils.log("addLicense");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"INSERT INTO Licenses 
                (ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                VALUES (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
			cmd.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassID);
			cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
			if (license.Notes == "")
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Notes", license.Notes);
			cmd.Parameters.AddWithValue("@PaidFees", license.PaidFees);
			cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
			cmd.Parameters.AddWithValue("@IssueReason", license.IssueReason);
			cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

			int licenseId = -1;

			try
			{
				connection.Open();
				object obj = cmd.ExecuteScalar();
				if (obj != null)
					int.TryParse(obj.ToString(), out licenseId);
			}
			catch (Exception ex)
			{
				clsUtils.logError("addLicense: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			return licenseId;
		}

		public static bool updateLicense(stLicense license)
		{
			clsUtils.log("updateLicense");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"UPDATE Licenses
                SET ApplicationID = @ApplicationID,
                    DriverID = @DriverID,
                    LicenseClassID = @LicenseClassID,
                    IssueDate = @IssueDate,
                    ExpirationDate = @ExpirationDate,
                    Notes = @Notes,
                    PaidFees = @PaidFees,
                    IsActive = @IsActive,
                    IssueReason = @IssueReason,
                    CreatedByUserID = @CreatedByUserID
                WHERE LicenseID = @LicenseID";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
			cmd.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassID);
			cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
			if (license.Notes == "")
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Notes", license.Notes);
			cmd.Parameters.AddWithValue("@PaidFees", license.PaidFees);
			cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
			cmd.Parameters.AddWithValue("@IssueReason", license.IssueReason);
			cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
			cmd.Parameters.AddWithValue("@LicenseID", license.LicenseID);

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
				clsUtils.logError("updateLicense: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		public static bool deleteLicenseById(int id)
		{
			clsUtils.log("deleteLicenseById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "DELETE FROM Licenses WHERE LicenseID = @id";
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
				clsUtils.logError($"deleteLicense: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		public static stLicense GetLicensePerIsActiveAndApplication(bool IsActive, int ApplicationID)
		{
			clsUtils.log("GetLicensePerIsActiveAndApplication");

			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Licenses where ApplicationID = @ApplicationID and IsActive = @IsActive;";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);

			stLicense license = new stLicense();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					license = new stLicense(
						(int)reader["LicenseID"],
						(int)reader["ApplicationID"],
						(int)reader["DriverID"],
						(int)reader["LicenseClassID"],
						(DateTime)reader["IssueDate"],
						(DateTime)reader["ExpirationDate"],
						reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"],
						(decimal)reader["PaidFees"],
						(bool)reader["IsActive"],
						(Byte)reader["IssueReason"],
						(int)reader["CreatedByUserID"]
					);
				}
				else
					throw new Exception("License Not Found");
				reader.Close();
			}
			catch (Exception ex)
			{
				clsUtils.logError("GetLicensePerIsActiveAndApplication: " + ex.Message);
				license.LicenseID = -1;
			}
			finally
			{
				connection.Close();
			}
			return license;
		}

		public static DataTable getAllLicensesByDriverID(int DriverID)
		{
			clsUtils.log("getAllLicensesByDriverID");

			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"select * from Licenses where DriverID = @DriverID";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.Add("@DriverID", DriverID);

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
					dataTable.Load(reader);
			}
			catch (Exception ex)
			{
				clsUtils.logError("getAllLicensesByDriverID: " + ex.Message);
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