
using System;
using System.Data; // for DataTable
using System.Data.SqlClient;
using System.Resources; // ado.net sqlserver client

namespace DataAccessLayer
{
	public class clsPersonData
	{
		public struct stPerson
		{
			public int PersonID { get; set; }
			public string NationalNo { get; set; }
			public string FirstName { get; set; }
			public string SecondName { get; set; }
			public string ThirdName { get; set; }
			public string LastName { get; set; }
			public DateTime DateOfBirth { get; set; }
			public Byte Gender { get; set; }
			public string Address { get; set; }
			public string Phone { get; set; }
			public string Email { get; set; }
			public int NationalityCountryID { get; set; }
			public string ImagePath { get; set; }

			public stPerson(
				int personID,
				string nationalNo,
				string firstName,
				string secondName,
				string thirdName,
				string lastName,
				DateTime dateOfBirth,
				Byte gender,
				string address,
				string phone,
				string email,
				int nationalityCountryID,
				string imagePath)
			{
				PersonID = personID;
				NationalNo = nationalNo;
				FirstName = firstName;
				SecondName = secondName;
				ThirdName = thirdName;
				LastName = lastName;
				DateOfBirth = dateOfBirth;
				Gender = gender;
				Address = address;
				Phone = phone;
				Email = email;
				NationalityCountryID = nationalityCountryID;
				ImagePath = imagePath;
			}
		}

		static public DataTable getAllPeople()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("getAllPeople()");
			Console.ResetColor();

			DataTable dataTable = new DataTable();

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from People;";
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
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"getAllPeople: {ex.Message}");
				Console.ResetColor();
				dataTable = null;
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}

		static public stPerson getPersonByID(int id)
		{
			clsSettings.log($"getPersonByID");

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "select * from People where People.PersonID = @id";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@id", id);

			stPerson person;

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					person = new stPerson((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], reader[4] != DBNull.Value? (string)reader[4] : "",
						(string)reader[5], (DateTime)reader[6], (Byte)reader[7], (string)reader[8], (string)reader[9], reader[10]!= DBNull.Value?(string)reader[10]:"",
						(int)reader[11], reader[12]!= DBNull.Value?(string)reader[12]:"");
				}
				else
				{
					throw new Exception("Person Not Found");
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				clsSettings.logError($"getPersonByID: {ex.Message}");
				person = new stPerson();
				person.PersonID = -1;
			}
			finally
			{
				connection.Close();
			}
			return person;
		}

		static public int addPerson(stPerson person)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("addPerson()");
			Console.ResetColor();

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"insert into People (NationalNo, FirstName, SecondName, ThirdName, LastName,
				DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) values
				(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)
				SELECT SCOPE_IDENTITY()";
			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@NationalNo", person.NationalNo);
			cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
			cmd.Parameters.AddWithValue("@SecondName", person.SecondName);

			if (person.ThirdName == "")
				cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@ThirdName", person.ThirdName);
				
			cmd.Parameters.AddWithValue("@LastName", person.LastName);
			cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
			cmd.Parameters.AddWithValue("@Gendor", person.Gender);
			cmd.Parameters.AddWithValue("@Address", person.Address);
			cmd.Parameters.AddWithValue("@Phone", person.Phone);

			if (person.Email == "")
				cmd.Parameters.AddWithValue("@Email", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Email", person.Email);

			cmd.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);

			if (person.ImagePath == "")
				cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@ImagePath", person.ImagePath);

			int personId = -1;

			try
			{
				connection.Open();
				object obj = cmd.ExecuteScalar();
				if (obj != null)
					int.TryParse(obj.ToString(), out personId);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"addPerson: {ex.Message}");
				Console.ResetColor();
				person = new stPerson();
				person.PersonID = -1;
			}
			finally
			{
				connection.Close();
			}
			return personId;
		}

		static public bool updatePerson(stPerson person)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("updatePerson()");
			Console.ResetColor();

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = @"
				UPDATE [dbo].[People]
				   SET [NationalNo] = @NationalNo,
				       [FirstName] = @FirstName,
				       [SecondName] = @SecondName,
				       [ThirdName] = @ThirdName,
				       [LastName] = @LastName,
				       [DateOfBirth] = @DateOfBirth,
				       [Gendor] = @Gendor,
				       [Address] = @Address,
				       [Phone] = @Phone,
				       [Email] = @Email,
				       [NationalityCountryID] = @NationalityCountryID,
				       [ImagePath] = @ImagePath
				 WHERE [PersonID] = @PersonID";

			SqlCommand cmd = new SqlCommand(query, connection);
			cmd.Parameters.AddWithValue("@NationalNo", person.NationalNo);
			cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
			cmd.Parameters.AddWithValue("@SecondName", person.SecondName);

			if (person.ThirdName == "")
				cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@ThirdName", person.ThirdName);

			cmd.Parameters.AddWithValue("@LastName", person.LastName);
			cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
			cmd.Parameters.AddWithValue("@Gendor", person.Gender);
			cmd.Parameters.AddWithValue("@Address", person.Address);
			cmd.Parameters.AddWithValue("@Phone", person.Phone);

			if (person.Email == "")
				cmd.Parameters.AddWithValue("@Email", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@Email", person.Email);

			cmd.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);

			if (person.ImagePath == "")
				cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@ImagePath", person.ImagePath);

			cmd.Parameters.AddWithValue("@PersonID", person.PersonID);


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
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"updatePerson: {ex.Message}");
				Console.ResetColor();
			}
			finally
			{
				connection.Close();
			}
			return success;
		}

		static public bool deletePersonById(int id)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("deletePerson()");
			Console.ResetColor();

			SqlConnection connection = new SqlConnection(clsSettings.connectionString);
			string query = "delete from People where PersonID = @id";
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
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"deletePerson: {ex.Message}");
				Console.ResetColor();
			}
			finally
			{
				connection.Close();
			}
			return success;
		}
	}
}
