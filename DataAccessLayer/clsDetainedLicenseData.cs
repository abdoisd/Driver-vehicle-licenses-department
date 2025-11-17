using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class clsDetainedLicenseData
	{
		public struct stDetainedLicense
		{
			public int DetainID { get; set; }
			public int LicenseID { get; set; }
			public DateTime DetainDate { get; set; }
			public decimal FineFees { get; set; }
			public int CreatedByUserID { get; set; }
			public bool IsReleased { get; set; }
			public DateTime ReleaseDate { get; set; }
			public int ReleasedByUserID { get; set; }
			public int ReleaseApplicationID { get; set; }

			public stDetainedLicense(
				int detainID,
				int licenseID,
				DateTime detainDate,
				decimal fineFees,
				int createdByUserID,
				bool isReleased,
				DateTime releaseDate,
				int releasedByUserID,
				int releaseApplicationID)
			{
				DetainID = detainID;
				LicenseID = licenseID;
				DetainDate = detainDate;
				FineFees = fineFees;
				CreatedByUserID = createdByUserID;
				IsReleased = isReleased;
				ReleaseDate = releaseDate;
				ReleasedByUserID = releasedByUserID;
				ReleaseApplicationID = releaseApplicationID;
			}
		}

		public static DataTable GetAll()
		{
			clsUtils.log("clsDetainedLicenseData.GetAll");

			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = "SELECT * FROM DetainedLicenses";
				SqlCommand cmd = new SqlCommand(query, conn);
				try
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
						dt.Load(reader);
				}
				catch
				{
					clsUtils.logError("clsDetainedLicenseData.GetAll: Failed to retrieve detained licenses");
					dt = null;
				}
			}
			return dt;
		}

		public static stDetainedLicense GetByID(int detainID)
		{
			clsUtils.log($"clsDetainedLicenseData.GetByID: {detainID}");

			stDetainedLicense detainedLicense = new stDetainedLicense();
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@DetainID", detainID);
				try
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						detainedLicense = new stDetainedLicense(
							(int)reader["DetainID"],
							(int)reader["LicenseID"],
							(DateTime)reader["DetainDate"],
							(decimal)reader["FineFees"],
							(int)reader["CreatedByUserID"],
							(bool)reader["IsReleased"],
							reader["ReleaseDate"] != DBNull.Value ? (DateTime)reader["ReleaseDate"] : DateTime.MinValue,
							reader["ReleasedByUserID"] != DBNull.Value ? (int)reader["ReleasedByUserID"] : -1,
							reader["ReleaseApplicationID"] != DBNull.Value ? (int)reader["ReleaseApplicationID"] : -1
						);
					}
					else
					{
						detainedLicense.DetainID = -1;
					}
				}
				catch
				{
					clsUtils.logError($"clsDetainedLicenseData.GetByID: Failed to retrieve DetainID = {detainID}");
					detainedLicense.DetainID = -1;
				}
			}
			return detainedLicense;
		}

		public static stDetainedLicense GetByLicenseID(int LicenseID)
		{
			clsUtils.log($"clsDetainedLicenseData.GetByLicenseID: {LicenseID}");

			stDetainedLicense detainedLicense = new stDetainedLicense();
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
				try
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						detainedLicense = new stDetainedLicense(
							(int)reader["DetainID"],
							(int)reader["LicenseID"],
							(DateTime)reader["DetainDate"],
							(decimal)reader["FineFees"],
							(int)reader["CreatedByUserID"],
							(bool)reader["IsReleased"],
							reader["ReleaseDate"] != DBNull.Value ? (DateTime)reader["ReleaseDate"] : DateTime.MinValue,
							reader["ReleasedByUserID"] != DBNull.Value ? (int)reader["ReleasedByUserID"] : -1,
							reader["ReleaseApplicationID"] != DBNull.Value ? (int)reader["ReleaseApplicationID"] : -1
						);
					}
					else
					{
						detainedLicense.DetainID = -1;
					}
				}
				catch (Exception ex)
				{
					clsUtils.logError($"clsDetainedLicenseData.GetByLicenseID: " + ex.Message);
					detainedLicense.DetainID = -1;
				}
			}
			return detainedLicense;
		}

		public static int Add(stDetainedLicense detainedLicense)
		{
			clsUtils.log("clsDetainedLicenseData.Add");

			int newID = -1;
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = @"INSERT INTO DetainedLicenses
                    (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                    VALUES
                    (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                    SELECT SCOPE_IDENTITY();";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@LicenseID", detainedLicense.LicenseID);
				cmd.Parameters.AddWithValue("@DetainDate", detainedLicense.DetainDate);
				cmd.Parameters.AddWithValue("@FineFees", detainedLicense.FineFees);
				cmd.Parameters.AddWithValue("@CreatedByUserID", detainedLicense.CreatedByUserID);
				cmd.Parameters.AddWithValue("@IsReleased", detainedLicense.IsReleased);
				cmd.Parameters.AddWithValue("@ReleaseDate", detainedLicense.ReleaseDate == DateTime.MinValue ? (object)DBNull.Value : detainedLicense.ReleaseDate);
				cmd.Parameters.AddWithValue("@ReleasedByUserID", detainedLicense.ReleasedByUserID == -1 ? (object)DBNull.Value : detainedLicense.ReleasedByUserID);
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", detainedLicense.ReleaseApplicationID == -1 ? (object)DBNull.Value : detainedLicense.ReleaseApplicationID);

				try
				{
					conn.Open();
					object obj = cmd.ExecuteScalar();
					if (obj != null)
						int.TryParse(obj.ToString(), out newID);
				}
				catch (Exception ex)
				{
					clsUtils.logError("clsDetainedLicenseData.Add: " + ex.Message);
					newID = -1;
				}
			}
			return newID;
		}

		public static bool Update(stDetainedLicense detainedLicense)
		{
			clsUtils.log($"clsDetainedLicenseData.Update: DetainID = {detainedLicense.DetainID}");

			bool success = false;
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = @"UPDATE DetainedLicenses SET
                    LicenseID = @LicenseID,
                    DetainDate = @DetainDate,
                    FineFees = @FineFees,
                    CreatedByUserID = @CreatedByUserID,
                    IsReleased = @IsReleased,
                    ReleaseDate = @ReleaseDate,
                    ReleasedByUserID = @ReleasedByUserID,
                    ReleaseApplicationID = @ReleaseApplicationID
                    WHERE DetainID = @DetainID";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@LicenseID", detainedLicense.LicenseID);
				cmd.Parameters.AddWithValue("@DetainDate", detainedLicense.DetainDate);
				cmd.Parameters.AddWithValue("@FineFees", detainedLicense.FineFees);
				cmd.Parameters.AddWithValue("@CreatedByUserID", detainedLicense.CreatedByUserID);
				cmd.Parameters.AddWithValue("@IsReleased", detainedLicense.IsReleased);
				cmd.Parameters.AddWithValue("@ReleaseDate", detainedLicense.ReleaseDate == DateTime.MinValue ? (object)DBNull.Value : detainedLicense.ReleaseDate);
				cmd.Parameters.AddWithValue("@ReleasedByUserID", detainedLicense.ReleasedByUserID == -1 ? (object)DBNull.Value : detainedLicense.ReleasedByUserID);
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", detainedLicense.ReleaseApplicationID == -1 ? (object)DBNull.Value : detainedLicense.ReleaseApplicationID);
				cmd.Parameters.AddWithValue("@DetainID", detainedLicense.DetainID);

				try
				{
					conn.Open();
					int rows = cmd.ExecuteNonQuery();
					success = rows > 0;
				}
				catch
				{
					clsUtils.logError($"clsDetainedLicenseData.Update: Failed to update DetainID = {detainedLicense.DetainID}");
					success = false;
				}
			}
			return success;
		}

		public static bool Delete(int detainID)
		{
			clsUtils.log($"clsDetainedLicenseData.Delete: DetainID = {detainID}");

			bool success = false;
			using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
			{
				string query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@DetainID", detainID);
				try
				{
					conn.Open();
					int rows = cmd.ExecuteNonQuery();
					success = rows > 0;
				}
				catch
				{
					clsUtils.logError($"clsDetainedLicenseData.Delete: Failed to delete DetainID = {detainID}");
					success = false;
				}
			}
			return success;
		}
	}
}