using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	static public class clsUserData
	{
		public struct stUser
		{
			public int UserID { get; set; }
			public int PersonID { get; set; }
			public string UserName { get; set; }
			public string Password { get; set; }
			public bool IsActive { get; set; }

			public stUser(int userID, int personID, string userName,
				string password, bool isActive)
			{
				UserID = userID;
				PersonID = personID;
				UserName = userName;
				Password = password;
				IsActive = isActive;
			}
		}

		static public DataTable getAllUsers()
		{
			clsSettings.log("getAllUsers");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from users";
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
				clsSettings.logError($"getAllUsers: {ex.Message}");
				connection.Close();
				return null;
			}

			return dataTable;
		}

		static public stUser getUserById(int id)
		{
			clsSettings.log("getUserById");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM users WHERE UserID = @UserID";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserID", id);

			stUser user = new stUser();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					user.UserID = (int)reader["UserID"];
					user.PersonID = (int)reader["PersonID"];
					user.UserName = reader["UserName"].ToString();
					user.Password = reader["Password"].ToString();
					user.IsActive = (bool)reader["IsActive"];
				}
				else
				{
					throw new Exception("User not found");
				}

				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getUserById {ex.Message}");
				connection.Close();
				user.UserID = -1;
			}

			return user;
		}

		static public stUser getUserByPersonId(int id)
		{
			clsSettings.log("getUserByPersonId");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM users WHERE PersonID = @PersonID";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@PersonID", id);

			stUser user = new stUser();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					user.UserID = (int)reader["UserID"];
					user.PersonID = (int)reader["PersonID"];
					user.UserName = reader["UserName"].ToString();
					user.Password = reader["Password"].ToString();
					user.IsActive = (bool)reader["IsActive"];
				}
				else
				{
					throw new Exception("User not found");
				}

				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getUserByPersonId: {ex.Message}");
				connection.Close();
				user.UserID = -1;
			}

			return user;
		}

		static public int addUser(stUser user)
		{
			clsSettings.log("addUser");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"INSERT INTO users (PersonID, UserName, Password, IsActive)
					 VALUES (@PersonID, @UserName, @Password, @IsActive);
					 SELECT SCOPE_IDENTITY();";
			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@PersonID", user.PersonID);
			command.Parameters.AddWithValue("@UserName", user.UserName);
			command.Parameters.AddWithValue("@Password", user.Password);
			command.Parameters.AddWithValue("@IsActive", user.IsActive);

			try
			{
				connection.Open();
				int insertedId = Convert.ToInt32(command.ExecuteScalar());
				connection.Close();
				return insertedId;
			}
			catch (Exception ex)
			{
				clsSettings.logError($"addUser {ex.Message}");
				connection.Close();
				return -1;
			}
		}

		static public bool updateUser(stUser user)
		{
			clsSettings.log("updateUser");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"UPDATE users 
					 SET PersonID = @PersonID,
						 UserName = @UserName,
						 Password = @Password,
						 IsActive = @IsActive
					 WHERE UserID = @UserID";
			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@UserID", user.UserID);
			command.Parameters.AddWithValue("@PersonID", user.PersonID);
			command.Parameters.AddWithValue("@UserName", user.UserName);
			command.Parameters.AddWithValue("@Password", user.Password);
			command.Parameters.AddWithValue("@IsActive", user.IsActive);

			try
			{
				connection.Open();
				int affectedRows = command.ExecuteNonQuery();
				connection.Close();

				return affectedRows > 0;
			}
			catch (Exception ex)
			{
				clsSettings.logError($"updateUser {ex.Message}");
				connection.Close();
				return false;
			}
		}

		static public bool deleteUser(int id)
		{
			clsSettings.log("deleteUser");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "DELETE FROM users WHERE UserID = @UserID";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserID", id);

			try
			{
				connection.Open();
				int affectedRows = command.ExecuteNonQuery();
				connection.Close();

				return affectedRows > 0;
			}
			catch (Exception ex)
			{
				clsSettings.logError($"deleteUser {ex.Message}");
				connection.Close();
				return false;
			}
		}

		static public bool changePassword(int userId, string password)
		{
			clsSettings.log("changePassword");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "UPDATE users SET Password = @Password WHERE UserID = @UserID";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserID", userId);
			command.Parameters.AddWithValue("@Password", password);

			try
			{
				connection.Open();
				int affectedRows = command.ExecuteNonQuery();
				connection.Close();
				return affectedRows > 0;
			}
			catch (Exception ex)
			{
				clsSettings.logError($"changePassword: {ex.Message}");
				connection.Close();
				return false;
			}
		}

		static public stUser getUserByUsernameAndPassword(string username, string password)
		{
			clsSettings.log("getUserByUsernameAndPassword");
			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "SELECT * FROM users WHERE UserName = @UserName AND Password = @Password";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserName", username);
			command.Parameters.AddWithValue("@Password", password);

			stUser user = new stUser();

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					user.UserID = (int)reader["UserID"];
					user.PersonID = (int)reader["PersonID"];
					user.UserName = reader["UserName"].ToString();
					user.Password = reader["Password"].ToString();
					user.IsActive = (bool)reader["IsActive"];
				}
				else
				{
					throw new Exception("User not found");
				}
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getUserByUsernameAndPassword: {ex.Message}");
				connection.Close();
				user.UserID = -1;
			}
			return user;
		}

	}
}
