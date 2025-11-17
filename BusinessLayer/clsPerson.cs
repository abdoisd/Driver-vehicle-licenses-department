using DataAccessLayer;
using FullRealProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace BusinessLayer
{
	public class clsPerson
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

		// additional
		public string FullName
		{
			get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
		}

		public clsPerson()
		{
			PersonID = -1;
			NationalNo = "";
			FirstName = "";
			SecondName = "";
			ThirdName = "";
			LastName = "";
			DateOfBirth = DateTime.MinValue;
			Gender = 1;
			Address = "";
			Phone = "";
			Email = "";
			NationalityCountryID = -1;
			ImagePath = "";
		}

		private clsPerson(
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

		public clsPerson(
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

		public override string ToString()
		{
			return $"PersonID: {PersonID}\n" +
				   $"NationalNo: {NationalNo}\n" +
				   $"Name: {FirstName} {SecondName} {ThirdName} {LastName}\n" +
				   $"DateOfBirth: {DateOfBirth:yyyy-MM-dd}\n" +
				   $"Gender: {Gender}\n" +
				   $"Address: {Address}\n" +
				   $"Phone: {Phone}\n" +
				   $"Email: {Email}\n" +
				   $"NationalityCountryID: {NationalityCountryID}\n" +
				   $"ImagePath: {ImagePath}";
		}

		static public DataTable getAllPeople()
		{
			return (DataAccessLayer.clsPersonData.getAllPeople());
		}

		static public clsPerson getPersonById(int id)
		{
			DataAccessLayer.clsPersonData.stPerson person = DataAccessLayer.clsPersonData.getPersonByID(id);
			if (person.PersonID == -1)
				return null;
			return new clsPerson(person.PersonID, person.NationalNo, person.FirstName, person.SecondName, person.ThirdName, person.LastName,
				person.DateOfBirth, person.Gender, person.Address, person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);
		}

		public void	add()
		{
			PersonID = DataAccessLayer.clsPersonData.addPerson(new clsPersonData.stPerson(PersonID, NationalNo, FirstName, SecondName,
				ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath));
		}

		public bool update()
		{
			return DataAccessLayer.clsPersonData.updatePerson(new clsPersonData.stPerson(PersonID, NationalNo, FirstName, SecondName,
				ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath));
		}

		static public bool delete(int id)
		{
			return DataAccessLayer.clsPersonData.deletePersonById(id);
		}

		public bool delete()
		{
			return DataAccessLayer.clsPersonData.deletePersonById(PersonID);
		}

		// crud end
		public bool	hasActiveApplication(int LicenseClass, clsApplication.enApplicationStatuses ApplicationStatus)
		{
			DataTable dataTable = clsLocalDrivingLicenseApplicationData.getLDLAPerLicenseClassIDPersonIDApplicationStatus(LicenseClass, this.PersonID, (Byte)ApplicationStatus);
			return dataTable.Rows.Count > 0;
		}

		/// <exception cref="Exception"></exception>
		public clsDriver MakeItDriver()
		{
			clsDriver driver = new clsDriver(-1, this.PersonID, clsGlobal.loggedInUser.UserID, DateTime.Now);
			driver.Add();
			return driver;
		}
	}
}
