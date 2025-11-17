using System;
using System.Data;
using System.Data.SqlClient;	

namespace DataAccessLayer
{
	public class clsLicenseClassData
	{
		public struct stLicenseClass
		{
			public int LicenseClassID { get; set; }
			public string ClassName { get; set; }
			public string ClassDescription { get; set; }
			public Byte MinimumAllowedAge { get; set; }
			public Byte DefaultValidityLength { get; set; }
			public decimal ClassFees { get; set; }
		}

		static public DataTable getAllLicenseClasses()
		{
			clsUtils.log("getAllLicenseClasses");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from LicenseClasses";
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
				clsUtils.logError($"getAllLicenseClasses: {ex.Message}");
				connection.Close();
				return null;
			}

			return dataTable;
		}

		static public stLicenseClass getLicenseClassById(int id)
		{
			clsUtils.log("getLicenseClassById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from LicenseClasses where LicenseClassID = @id";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", id);

			stLicenseClass licenseClass = new stLicenseClass();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					licenseClass.LicenseClassID = (int)reader["LicenseClassID"];
					licenseClass.ClassName = (string)reader["ClassName"];
					licenseClass.ClassDescription = (string)reader["ClassDescription"];
					licenseClass.MinimumAllowedAge = (Byte)reader["MinimumAllowedAge"];
					licenseClass.DefaultValidityLength = (Byte)reader["DefaultValidityLength"];
					licenseClass.ClassFees = (decimal)reader["ClassFees"];
				}
				else
					throw new Exception("License Class Not Found");
				reader.Close();
			}
			catch (Exception ex)
			{
				clsUtils.logError($"getLicenseClassById: {ex.Message}");
				connection.Close();
				licenseClass.LicenseClassID = -1;
			}
			return licenseClass;
		}
	}
}
