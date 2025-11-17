using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsLicense
	{
		// 11, with obj
		public int LicenseID { get; set; }

		int applicationID { get; set; }
		public int ApplicationID
		{ 
			get {  return applicationID; }
			set
			{
				applicationID = value;
				if (value == -1)
					Application = new clsApplication();
				else
					Application = clsApplication.getApplicationById(value);
			}
		}
		public clsApplication Application { get; set; }

		int driverID { get; set; }
		public int DriverID
		{ 
			get { return driverID; }
			set
			{
				driverID = value;
				if (value == -1)
					Driver = new clsDriver();
				else
					Driver = clsDriver.GetDriverByID(value);
			}
		}
		public clsDriver Driver { get; set; }

		int licenseClassID { get; set; }
		public int LicenseClassID
		{
			get { return licenseClassID; }
			set
			{
				licenseClassID = value;
				if (value == -1)
					LicenseClass = new clsLicenseClass();
				else
					LicenseClass = clsLicenseClass.getLicenseClassById(value);
			}
		}
		public clsLicenseClass LicenseClass { get; set; }

		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Notes { get; set; }
		public decimal PaidFees { get; set; }
		public bool IsActive { get; set; }
		public enum enIssureReasons
		{
			FirstTime = 1,
			Renew,
			ReplacementForDamaged,
			ReplacementForLost
		}
		public enIssureReasons IssueReason { get; set; }

		int createdByUserID { get; set; }
		public int CreatedByUserID 
		{
			get { return createdByUserID; }
			set
			{
				createdByUserID = value;
				if (value == -1)
					CreatedByUser = new clsUser();
				else
					CreatedByUser = clsUser.getUserById(value);
			}
		}
		public clsUser CreatedByUser { get; set; }

		public clsLicense()
		{
			LicenseID = -1;
			ApplicationID = -1;
			DriverID = -1;
			LicenseClassID = -1;
			IssueDate = DateTime.MinValue;
			ExpirationDate = DateTime.MinValue;
			Notes = null;
			PaidFees = 0;
			IsActive = false;
			IssueReason = enIssureReasons.FirstTime;
			CreatedByUserID = -1;
		}

		public clsLicense(int licenseID, int applicationID, int driverID, int licenseClassID,
			DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees,
			bool isActive, enIssureReasons issueReason, int createdByUserID)
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

		/// <exception cref="Exception"></exception>
		public static DataTable GetAllLicenses()
		{
			var dt = clsLicenseData.getAllLicenses();
			if (dt == null)
				throw new Exception("Failed to retrieve licenses.");
			return dt;
		}

		public static clsLicense GetLicenseByID(int licenseID)
		{
			var data = clsLicenseData.getLicenseByID(licenseID);
			if (data.LicenseID == -1)
				return null;
			return new clsLicense(
				data.LicenseID,
				data.ApplicationID,
				data.DriverID,
				data.LicenseClassID,
				data.IssueDate,
				data.ExpirationDate,
				data.Notes,
				data.PaidFees,
				data.IsActive,
				(enIssureReasons)data.IssueReason,
				data.CreatedByUserID
			);
		}

		/// <exception cref="Exception"></exception>
		public void Add()
		{
			var st = new clsLicenseData.stLicense(
				0,
				this.ApplicationID,
				this.DriverID,
				this.LicenseClassID,
				this.IssueDate,
				this.ExpirationDate,
				this.Notes,
				this.PaidFees,
				this.IsActive,
				(Byte)this.IssueReason,
				this.CreatedByUserID
			);
			int id = clsLicenseData.addLicense(st);
			this.LicenseID = id;
			if (id <= 0)
				throw new Exception("Failed to add license.");
		}

		/// <exception cref="Exception"></exception>
		public void Update()
		{
			var st = new clsLicenseData.stLicense(
				this.LicenseID,
				this.ApplicationID,
				this.DriverID,
				this.LicenseClassID,
				this.IssueDate,
				this.ExpirationDate,
				this.Notes,
				this.PaidFees,
				this.IsActive,
				(Byte)this.IssueReason,
				this.CreatedByUserID
			);
			bool result = clsLicenseData.updateLicense(st);
			if (!result)
				throw new Exception("Failed to update license.");
		}

		/// <exception cref="Exception"></exception>
		public void Delete()
		{
			bool result = clsLicenseData.deleteLicenseById(this.LicenseID);
			if (!result)
				throw new Exception("Failed to delete license.");
		}

		/// <exception cref="Exception"></exception>
		public static void DeleteLicenseById(int licenseID)
		{
			bool result = clsLicenseData.deleteLicenseById(licenseID);
			if (!result)
				throw new Exception("Failed to delete license.");
		}

		public clsDetainedLicense GetDetainInfo()
		{
			return clsDetainedLicense.GetByLicenseID(this.LicenseID);
		}
	}
}