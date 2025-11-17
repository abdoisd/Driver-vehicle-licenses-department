using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
	public class clsUser
	{
		public int UserID { get; set; }

		int personId;
		public int PersonID
		{
			get {  return personId; }
			set
			{
				personId = value;
				if (value == -1)
					Person = new clsPerson();
				else
					Person = clsPerson.getPersonById(value);
			}
		}
		public clsPerson Person { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }

		// utils

		public clsUser()
		{
			UserID = -1;
			PersonID = -1;
			UserName = "";
			Password = "";
			IsActive = false;
		}

		public clsUser(int userID, int personID, string userName, string password, bool isActive)
		{
			UserID = userID;
			PersonID = personID;
			UserName = userName;
			Password = password;
			IsActive = isActive;
		}

		public override string ToString()
		{
			return $"UserID: {UserID}, PersonID: {PersonID}, UserName: {UserName}, Password: {Password}, IsActive: {IsActive}";
		}

		// methods

		static public DataTable getAllUsers()
		{
			return DataAccessLayer.clsUserData.getAllUsers();
		}

		static public clsUser getUserById(int id)
		{
			DataAccessLayer.clsUserData.stUser user = clsUserData.getUserById(id);
			if (user.UserID == -1)
				return null;
			else
				return new clsUser(user.UserID, user.PersonID, user.UserName, user.Password, user.IsActive);
		}

		static public clsUser getUserByPersonId(int personId)
		{
			DataAccessLayer.clsUserData.stUser user = clsUserData.getUserByPersonId(personId);
			if (user.UserID == -1)
				return null;
			else
				return new clsUser(user.UserID, user.PersonID, user.UserName, user.Password, user.IsActive);
		}

		public bool add()
		{
			int userId = DataAccessLayer.clsUserData.addUser(new clsUserData.stUser(UserID, PersonID, UserName, Password, IsActive));
			if (userId != -1)
			{
				UserID = userId;
				return true;
			}
			return false;
		}

		public bool update()
		{
			return DataAccessLayer.clsUserData.updateUser(new clsUserData.stUser(UserID, PersonID, UserName, Password, IsActive));
		}

		public bool delete()
		{
			return DataAccessLayer.clsUserData.deleteUser(UserID);
		}

		static public bool deleteUser(int id)
		{
			return DataAccessLayer.clsUserData.deleteUser(id);
		}

		public bool changePassword(string newPassword)
		{
			return clsUserData.changePassword(UserID, newPassword);
		}

		static public bool changePassword(int userId, string newPassword)
		{
			return clsUserData.changePassword(userId, newPassword);
		}

		static public clsUser getUserByUsernameAndPassword(string username, string password)
		{
			clsUserData.stUser user = clsUserData.getUserByUsernameAndPassword(username, password);
			if (user.UserID == -1)
				return null;
			else
				return new clsUser(user.UserID, user.PersonID, user.UserName, user.Password, user.IsActive);
		}
	}
}
