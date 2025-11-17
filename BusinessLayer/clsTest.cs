using System;
using System.Data;
using System.Runtime.InteropServices;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsTest
	{
		// 5
		public int TestID { get; set; }

		int testAppointmentID;
		public int TestAppointmentID
		{
			get { return testAppointmentID; }
			set
			{
				testAppointmentID = value;
				if (value == -1)
					TestAppointment = new clsTestAppointment();
				else
					TestAppointment = clsTestAppointment.Get(value);
			}
		}
		public clsTestAppointment TestAppointment { get; set; } // obj

		public bool TestResult { get; set; }
		public string Notes { get; set; }
		public int CreatedByUserID { get; set; }

		public clsTest(
			int testID,
			int testAppointmentID,
			bool testResult,
			string notes,
			int createdByUserID)
		{
			TestID = testID;
			TestAppointmentID = testAppointmentID;
			TestResult = testResult;
			Notes = notes;
			CreatedByUserID = createdByUserID;
		}

		public static DataTable GetAll()
		{
			return clsTestData.getAllTests();
		}

		/// <summary>
		/// get by id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static clsTest Get(int id)
		{
			var data = clsTestData.getTestById(id);
			if (data.TestID == 0)
				return null;

			return new clsTest(data.TestID, data.TestAppointmentID, data.TestResult, data.Notes, data.CreatedByUserID);
		}

		public void Add()
		{
			var data = new clsTestData.stTest(
				0,
				this.TestAppointmentID,
				this.TestResult,
				this.Notes,
				this.CreatedByUserID
			);
			int id = clsTestData.addTest(data);
			this.TestID = id;
			if (id < 0)
				throw new Exception("Error Adding test");

			// lock test appointment
			if (!TestAppointment.Lock())
				clsUtils.logError("Error locking test appointment");

			// if last test, mark LDLA as completed
			if (this.TestAppointment.TestTypeID == clsTestType.enTestTypes.Street &&
				this.TestResult == true)
			{
				this.TestAppointment.LocalDrivingLicenseApplication.ApplicationStatus = clsLocalDrivingLicenseApplication.enApplicationStatuses.Completed;
				
				clsApplication application = this.TestAppointment.LocalDrivingLicenseApplication;
				application.Update();
			}
		}

		public bool Update()
		{
			var data = new clsTestData.stTest(
				this.TestID,
				this.TestAppointmentID,
				this.TestResult,
				this.Notes,
				this.CreatedByUserID
			);
			return clsTestData.updateTest(data);
		}

		public static bool Delete(int id)
		{
			return clsTestData.deleteTestById(id);
		}

		// get latest test
		// get test count per person
	}
}