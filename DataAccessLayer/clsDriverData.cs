using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class clsDriverData
	{
		public struct stDriver
		{
			public int DriverID { get; set; }
			public int PersonID { get; set; }
			public int CreatedByUserID { get; set; }
			public DateTime CreatedDate { get; set; }

			public stDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
			{
				DriverID = driverID;
				PersonID = personID;
				CreatedByUserID = createdByUserID;
				CreatedDate = createdDate;
			}
		}

		static public DataTable getAllDrivers()
		{
			clsUtils.log("getAllDrivers");

			DataTable dataTable = new DataTable();
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Drivers;";
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
				clsUtils.logError("getAllDrivers: " + ex.Message);
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		static public stDriver getDriverByID(int id)
		{
			clsUtils.log("getDriverByID");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM Drivers WHERE DriverID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);

			stDriver driver = new stDriver();

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					driver = new stDriver(
						(int)reader["DriverID"],
						(int)reader["PersonID"],
						(int)reader["CreatedByUserID"],
						(DateTime)reader["CreatedDate"]
					);
				}
				else
					throw new Exception("Driver Not Found");
				reader.Close();
			}
			catch (Exception ex)
			{
				clsUtils.logError("getAllDrivers: " + ex.Message);
				driver.DriverID = -1;
			}
			finally
			{
				connection.Close();
			}
			return driver;
		}

		static public int addDriver(stDriver driver)
		{
			clsUtils.log("addDriver");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
			cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
			cmd.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

			int driverId = -1;

			try
			{
				connection.Open();
				object obj = cmd.ExecuteScalar();
				if (obj != null)
					int.TryParse(obj.ToString(), out driverId);
			}
			catch (Exception ex)
			{
				clsUtils.logError("addDriver: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			return driverId;
		}

		static public bool updateDriver(stDriver driver)
		{
			clsUtils.log("updateDriver");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"UPDATE Drivers
                             SET PersonID = @PersonID,
                                 CreatedByUserID = @CreatedByUserID,
                                 CreatedDate = @CreatedDate
                             WHERE DriverID = @DriverID";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
			cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
			cmd.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);
			cmd.Parameters.AddWithValue("@DriverID", driver.DriverID);

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
				clsUtils.logError("updateDriver: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		static public bool deleteDriverById(int id)
		{
			clsUtils.log("deleteDriverById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "DELETE FROM Drivers WHERE DriverID = @id";
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
				clsUtils.logError($"deleteDriver: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return success;
		}
	}
}