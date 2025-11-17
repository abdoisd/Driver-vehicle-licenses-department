using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsApplication
	{
		// 8 members
		public int ApplicationID { get; set; }

		private int applicantPersonID;
		public int ApplicantPersonID
		{
			get
			{
				return applicantPersonID;
			}
			set
			{
				applicantPersonID = value;
				if (value == -1)
					ApplicantPerson = new clsPerson();
				else
					ApplicantPerson = clsPerson.getPersonById(value);
			}
		}
		public clsPerson ApplicantPerson { get; set; }

		public DateTime ApplicationDate { get; set; }

		public enum enApplicationTypes {
			NewDrivingLicense = 1, RenewDrivingLicense, ReplaceLostDrivingLicense,
			ReplaceDamagedDrivingLicense, ReleaseDetainedDrivingLicense, NewInternationalLicense, RetakeTest
		}
		int applicationTypeID;
		public int ApplicationTypeID 
		{ 
			get { return applicationTypeID; }
			set
			{
				applicationTypeID = value;
				if (value == -1)
					ApplicationType = new clsApplicationType();
				else
					ApplicationType = clsApplicationType.getApplicationTypeById(value);
			}
		}
		public clsApplicationType ApplicationType { get; set; }

		public enum enApplicationStatuses { New = 1, Cancelled, Completed }
		public enApplicationStatuses ApplicationStatus { get; set; } // tiny int

		public DateTime LastStatusDate { get; set; }
		public decimal PaidFees { get; set; } // small money

		int createdByUserID;
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

		public clsApplication()
		{
			ApplicationID = -1;
			ApplicantPersonID = -1;
			CreatedByUserID = -1;
			ApplicantPerson = CreatedByUser.Person;
			ApplicationDate = DateTime.MinValue;
			ApplicationTypeID = -1;
			ApplicationStatus = 0;
			LastStatusDate = DateTime.MinValue;
			PaidFees = -1;
		}

		// passed 1 here
		public clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
				int applicationTypeID, enApplicationStatuses applicationStatus, DateTime lastStatusDate, decimal paidFees,
				int createdByUserID)
		{
			ApplicationID = applicationID;

			CreatedByUserID = createdByUserID;

			ApplicantPersonID = applicantPersonID;
			ApplicantPerson = CreatedByUser.Person;

			ApplicationDate = applicationDate;

			ApplicationTypeID = applicationTypeID;
			ApplicationType = clsApplicationType.getApplicationTypeById(applicationTypeID);

			ApplicationStatus = applicationStatus;
			LastStatusDate = lastStatusDate;
			PaidFees = paidFees;
		}

		public static DataTable getAllApplication()
		{
			return clsApplication.getAllApplication();
		}

		public static clsApplication getApplicationById(int id)
		{
			var data = clsApplicationData.getApplicationById(id);
			if (data.ApplicationID == -1)
				return null;

			return new clsApplication(
				data.ApplicationID,
				data.ApplicantPersonID,
				data.ApplicationDate,
				data.ApplicationTypeID,
				(enApplicationStatuses)data.ApplicationStatus,
				data.LastStatusDate,
				data.PaidFees,
				data.CreatedByUserID
			);
		}

		public bool add()
		{
			clsApplicationData.stApplication data = new clsApplicationData.stApplication
			{
				ApplicantPersonID = this.ApplicantPersonID,
				ApplicationDate = this.ApplicationDate,
				ApplicationTypeID = this.ApplicationTypeID,
				ApplicationStatus = (Byte)this.ApplicationStatus,
				LastStatusDate = this.LastStatusDate,
				PaidFees = this.PaidFees,
				CreatedByUserID = this.CreatedByUserID
			};

			this.ApplicationID = clsApplicationData.addApplication(data);

			return this.ApplicationID > 0;
		}

		public bool Update()
		{
			clsApplicationData.stApplication data = new clsApplicationData.stApplication
			{
				ApplicationID = this.ApplicationID,
				ApplicantPersonID = this.ApplicantPersonID,
				ApplicationDate = this.ApplicationDate,
				ApplicationTypeID = this.ApplicationTypeID,
				ApplicationStatus = (Byte)this.ApplicationStatus,
				LastStatusDate = this.LastStatusDate,
				PaidFees = this.PaidFees,
				CreatedByUserID = this.CreatedByUserID
			};

			return clsApplicationData.updateApplication(data);
		}

		public static bool Delete(int id)
		{
			return clsApplicationData.deleteApplication(id);
		}

		public bool Delete()
		{
			if (this.ApplicationID <= 0)
				return false;
			return clsApplicationData.deleteApplication(this.ApplicationID);
		}

		// crud end
		public clsLicense	getActiveLicense()
		{
			clsLicenseData.stLicense	data = clsLicenseData.GetLicensePerIsActiveAndApplication(true, this.ApplicationID);
			if (data.LicenseID == -1)
				return null;
			else
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
					(clsLicense.enIssureReasons)data.IssueReason,
					data.CreatedByUserID
				);
		}
	}
}
