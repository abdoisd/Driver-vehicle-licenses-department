using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsInternationalLicensesData
    {
        public struct stInternationalLicense
        {
            public int InternationalLicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public int IssuedUsingLocalLicenseID { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public bool IsActive { get; set; }
            public int CreatedByUserID { get; set; }

            public stInternationalLicense(
                int internationalLicenseID,
                int applicationID,
                int driverID,
                int issuedUsingLocalLicenseID,
                DateTime issueDate,
                DateTime expirationDate,
                bool isActive,
                int createdByUserID)
            {
                InternationalLicenseID = internationalLicenseID;
                ApplicationID = applicationID;
                DriverID = driverID;
                IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
                IssueDate = issueDate;
                ExpirationDate = expirationDate;
                IsActive = isActive;
                CreatedByUserID = createdByUserID;
            }
        }

        public static DataTable GetAll()
        {
            clsUtils.log("clsInternationalLicensesData.GetAll");

			DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
            {
                string query = "SELECT * FROM InternationalLicenses";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        dt.Load(reader);
                }
                catch (Exception ex)
				{
                    clsUtils.logError("clsInternationalLicensesData.GetAll: " + ex.Message);
					dt = null;
                }
            }
            return dt;
        }

        public static stInternationalLicense GetByID(int internationalLicenseID)
        {
            clsUtils.log("clsInternationalLicensesData.GetByID");

			stInternationalLicense license = new stInternationalLicense();
            using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
            {
                string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        license = new stInternationalLicense(
                            (int)reader["InternationalLicenseID"],
                            (int)reader["ApplicationID"],
                            (int)reader["DriverID"],
                            (int)reader["IssuedUsingLocalLicenseID"],
                            (DateTime)reader["IssueDate"],
                            (DateTime)reader["ExpirationDate"],
                            (bool)reader["IsActive"],
                            (int)reader["CreatedByUserID"]
                        );
                    }
                    else
                    {
                        license.InternationalLicenseID = -1;
                    }
                }
                catch (Exception ex)
				{
                    clsUtils.logError("clsInternationalLicensesData.GetByID: " + ex.Message);
					license.InternationalLicenseID = -1;
                }
            }
            return license;
        }

        public static int Add(stInternationalLicense license)
        {
            clsUtils.log("clsInternationalLicensesData.Add");

			int newID = -1;
            using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
            {
                string query = @"INSERT INTO InternationalLicenses
                    (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                    VALUES
                    (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssuedUsingLocalLicenseID);
                cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                try
                {
                    conn.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                        int.TryParse(obj.ToString(), out newID);
                }
                catch (Exception ex)
				{
                    clsUtils.logError("clsInternationalLicensesData.Add: " + ex.Message);
					newID = -1;
                }
            }
            return newID;
        }

        public static bool Update(stInternationalLicense license)
        {
            clsUtils.log("clsInternationalLicensesData.Update");

			bool success = false;
            using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
            {
                string query = @"UPDATE InternationalLicenses SET
                    ApplicationID = @ApplicationID,
                    DriverID = @DriverID,
                    IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                    IssueDate = @IssueDate,
                    ExpirationDate = @ExpirationDate,
                    IsActive = @IsActive,
                    CreatedByUserID = @CreatedByUserID
                    WHERE InternationalLicenseID = @InternationalLicenseID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssuedUsingLocalLicenseID);
                cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
                cmd.Parameters.AddWithValue("@InternationalLicenseID", license.InternationalLicenseID);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    success = rows > 0;
                }
                catch (Exception ex)
				{
                    clsUtils.logError("clsInternationalLicensesData.Update: " + ex.Message);
					success = false;
                }
            }
            return success;
        }

        public static bool Delete(int internationalLicenseID)
        {
            clsUtils.log("clsInternationalLicensesData.Delete");

			bool success = false;
            using (SqlConnection conn = new SqlConnection(clsSettings.connectionString))
            {
                string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    success = rows > 0;
                }
                catch (Exception ex)
				{
                    clsUtils.logError("clsInternationalLicensesData.Delete: " + ex.Message);
					success = false;
                }
            }
            return success;
        }
    }
}