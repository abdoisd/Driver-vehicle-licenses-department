using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using DataAccessLayer;
using FullRealProject;

namespace BusinessLayer
{
	public class clsLocalDrivingLicenseApplication : clsApplication
	{
		public int LocalDrivingLicenseApplicationID { get; set; }

		int licenseClassID;
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

		public clsLocalDrivingLicenseApplication()
			: base()
		{
			LocalDrivingLicenseApplicationID = -1;
			LicenseClassID = -1;
		}

		public clsLocalDrivingLicenseApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
				int applicationTypeID, enApplicationStatuses applicationStatus, DateTime lastStatusDate, decimal paidFees,
				int createdByUserID, int localDrivingLicenseApplicationID, int licenseClassID)
			: base(applicationID, applicantPersonID, applicationDate, applicationTypeID, applicationStatus,
				  lastStatusDate, paidFees, createdByUserID)
		{
			LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
			LicenseClassID = licenseClassID;
		}

		static public DataTable GetLocalDrivingLicensesView()
		{
			return clsLocalDrivingLicenseApplicationData.getLocalDrivingLicenseView();
		}

		public static clsLocalDrivingLicenseApplication GetById(int id)
		{
			var localApplication = clsLocalDrivingLicenseApplicationData.getLocalDrivingLicenseApplicationById(id);
			if (localApplication.LocalDrivingLicenseApplicationID == -1)
				return null;
			else
			{
				clsApplication application = getApplicationById(localApplication.ApplicationID);
				if (application != null)
				{
					return new clsLocalDrivingLicenseApplication(application.ApplicationID, application.ApplicantPerson.PersonID,
						application.ApplicationDate, application.ApplicationTypeID, application.ApplicationStatus, application.LastStatusDate,
						application.PaidFees, application.CreatedByUserID, localApplication.LocalDrivingLicenseApplicationID,
						localApplication.LicenseClassID);
				}
				else
				{
					clsUtils.logError("Error: application without it's base application, that's weird");
					return null;
				}
			}
		}

		/// <exception cref="Exception"></exception>
		public void Add()
		{
			if (this.ApplicantPerson.hasActiveApplication(this.licenseClassID, enApplicationStatuses.New))
				throw new Exception("Person already has an active application with the same class");

			if (this.ApplicantPerson.hasActiveApplication(this.licenseClassID, enApplicationStatuses.Completed))
				throw new Exception("Person already completed this class of application");

			if (!base.add())
			{
				clsUtils.logError("Failed to add base application."); // for debuging
				throw new Exception("Failure saving application"); // for system/program user
			}

			var localApplication = new clsLocalDrivingLicenseApplicationData.stLocalDrivingLicenseApplicationData(
				this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);

			int id = clsLocalDrivingLicenseApplicationData.addLocalDrivingLicenseApplication(localApplication);
			if (id == -1)
			{
				clsUtils.logError("Failed to add local application.");
				throw new Exception("Failure saving application");
			}

			this.LocalDrivingLicenseApplicationID = id;
		}

		public bool Update()
		{
			return clsLocalDrivingLicenseApplicationData.updateLocalDrivingLicenseApplication(
				new clsLocalDrivingLicenseApplicationData.stLocalDrivingLicenseApplicationData(
					LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID
					)
				);
		}

		public new bool Delete()
		{
			if (!clsLocalDrivingLicenseApplicationData.deleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
			{
				clsUtils.logError("Failed to delete local driving license application.");
				return false;
			}

			if (!base.Delete())
			{
				clsUtils.logError("Failed to delete base application.");
				return false;
			}

			return true;
		}

		public new static bool Delete(int id)
		{
			var localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetById(id);

			List<clsTestAppointment> list = localDrivingLicenseApplication.GetTestAppointments();
			foreach (clsTestAppointment testAppointment in list)
				testAppointment.Delete();

			// delete this
			if (!clsLocalDrivingLicenseApplicationData.deleteLocalDrivingLicenseApplication(id))
			{
				clsUtils.logError("Failed to delete local driving license application by ID.");
				return false;
			}

			// delete base data
			if (!clsApplication.Delete(localDrivingLicenseApplication.ApplicationID))
			{
				clsUtils.logError("Failed to delete base application by ID.");
				return false;
			}

			return true;
		}

		// not crud

		/// <exception cref="Exception"></exception>
		public void Cancel() // to test
		{
			if (this.ApplicationStatus == enApplicationStatuses.Completed)
				throw new Exception("You can't cancel a completed application");

			if (this.ApplicationStatus == enApplicationStatuses.Cancelled)
				throw new Exception("Application already cancelled");

			this.ApplicationStatus = enApplicationStatuses.Cancelled;

			if (!base.Update())
				throw new Exception("Error canceling application");
		}

		public int TotalNumberOfSuccessfullyPassedTests()
		{
			return clsTestData.testsPassedCountPerLDLAId(LocalDrivingLicenseApplicationID);
		}

		public bool HasUnlockedTestAppointmentsOfTestType(clsTestType.enTestTypes testType)
		{
			DataTable dataTable = clsTestAppointmentData.getTestAppointmentsPerTestTypeIsLockedLDLAID((int)testType, false, this.LocalDrivingLicenseApplicationID);
			return dataTable.Rows.Count > 0;
		}

		public bool HasLockedTestAppointmentsOfTestType(clsTestType.enTestTypes testType)
		{
			DataTable dataTable = clsTestAppointmentData.getTestAppointmentsPerTestTypeIsLockedLDLAID((int)testType, true, this.LocalDrivingLicenseApplicationID);
			return dataTable.Rows.Count > 0;
		}

		public DataTable GetTestAppointmentsOfTestType(clsTestType.enTestTypes TestTypeID)
		{
			return clsTestAppointmentData.getTestappointmentsPerLDLATestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
		}

		public List<clsTestAppointment> GetTestAppointments()
		{
			List<clsTestAppointment> list = new List<clsTestAppointment> ();
			DataTable dataTable = clsTestAppointmentData.getTestappointmentsPerLDLA(this.LocalDrivingLicenseApplicationID);
			foreach (DataRow row in dataTable.Rows)
				list.Add(clsTestAppointment.Get((int)row[0]));
			return list;
		}

		public void	IssueDrivingLicense(string notes)
		{
			clsDriver driver = this.ApplicantPerson.MakeItDriver(); //?
			clsLicense license = new clsLicense(-1, this.ApplicationID, driver.DriverID,
				this.LicenseClass.LicenseClassID, DateTime.Now, DateTime.Now.AddYears(this.LicenseClass.DefaultValidityLength),
				notes, this.PaidFees, true, clsLicense.enIssureReasons.FirstTime, clsGlobal.loggedInUser.UserID);
			license.Add();
		}

		public bool hasLicense()
		{
			clsLicenseData.stLicense license = clsLicenseData.getLicenseByLDLA(this.LocalDrivingLicenseApplicationID);
			if (license.LicenseID == -1)
				return false;
			return true;
		}
	}
}
