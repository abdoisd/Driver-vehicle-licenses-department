using System;
using System.Data;
using System.Xml.Schema;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsTestAppointment
	{
		// 8, no objs
		public int TestAppointmentID { get; set; }

		clsTestType.enTestTypes testTypeID;
		public clsTestType.enTestTypes TestTypeID
		{
			get { return testTypeID; }
			set
			{
				testTypeID = value;
				if ((int)value == -1)
					TestType = new clsTestType();
				else
					TestType = clsTestType.getByID((int)value);
			}
		}
		public clsTestType TestType { get; set; } // obj

		int localDrivingLicenseApplicationID;
		public int LocalDrivingLicenseApplicationID 
		{ 
			get {  return localDrivingLicenseApplicationID; }
			set
			{
				localDrivingLicenseApplicationID = value;
				if (value == -1)
					LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
				else
					LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetById(value);
			}
		}
		public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; } // obj

		public DateTime TestDate { get; set; }
		public decimal PaidFees { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsLocked { get; set; }
		public int RetakeTestApplicationID { get; set; }
		// obj for this

		public clsTestAppointment()
		{
			TestAppointmentID = -1;
			TestTypeID = clsTestType.enTestTypes.Vision;
			LocalDrivingLicenseApplicationID = -1;
			TestDate = DateTime.MinValue;
			PaidFees = 0.0m;
			CreatedByUserID = -1; // default to logged in user
			IsLocked = false;
			RetakeTestApplicationID = -1; // no retake by default
		}

		public clsTestAppointment(
			int testAppointmentID,
			clsTestType.enTestTypes testTypeID,
			int localDrivingLicenseApplicationID,
			DateTime testDate,
			decimal paidFees,
			int createdByUserID,
			bool isLocked,
			int retakeTestApplicationID)
		{
			TestAppointmentID = testAppointmentID;
			TestTypeID = testTypeID;
			LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
			TestDate = testDate;
			PaidFees = paidFees;
			CreatedByUserID = createdByUserID;
			IsLocked = isLocked;
			RetakeTestApplicationID = retakeTestApplicationID;
		}

		public static DataTable GetAll()
		{
			return clsTestAppointmentData.getAllTestAppointments();
		}

		/// <summary>
		/// get by id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static clsTestAppointment Get(int id)
		{
			var data = clsTestAppointmentData.getTestAppointmentById(id);
			if (data.TestAppointmentID == -1)
				return null;

			return new clsTestAppointment
			{
				TestAppointmentID = data.TestAppointmentID,
				TestTypeID = (clsTestType.enTestTypes)data.TestTypeID,
				LocalDrivingLicenseApplicationID = data.LocalDrivingLicenseApplicationID,
				TestDate = data.TestDate,
				PaidFees = data.PaidFees,
				CreatedByUserID = data.CreatedByUserID,
				IsLocked = data.IsLocked,
				RetakeTestApplicationID = data.RetakeTestApplicationID
			};
		}

		/// <exception cref="Exception"></exception>
		public void Add()
		{
			// if LDLA already a test appointment with the same testType that is not locked
			// get testAppointments per (LDLAID and TestType and lockedStatus)
			// throw person has a active test appointment

			if (LocalDrivingLicenseApplication.HasUnlockedTestAppointmentsOfTestType(TestTypeID))
				throw new Exception("Person has a active test appointment");

			var data = new clsTestAppointmentData.stTestAppointment(
				-1,
				(int)this.TestTypeID,
				this.LocalDrivingLicenseApplicationID,
				this.TestDate,
				this.PaidFees,
				this.CreatedByUserID,
				this.IsLocked,
				this.RetakeTestApplicationID
			);
			int id = clsTestAppointmentData.addTestAppointment(data);
			this.TestAppointmentID = id;
			if (id < 0)
				throw new Exception("Failure adding test appointment");
		}

		public bool Update()
		{
			var data = new clsTestAppointmentData.stTestAppointment(
				this.TestAppointmentID,
				(int)this.TestTypeID,
				this.LocalDrivingLicenseApplicationID,
				this.TestDate,
				this.PaidFees,
				this.CreatedByUserID,
				this.IsLocked,
				this.RetakeTestApplicationID
			);
			return clsTestAppointmentData.updateTestAppointment(data);
		}

		public bool Delete()
		{
			// delete test result before it

			return clsTestAppointmentData.deleteTestAppointmentById(this.TestAppointmentID);
		}

		public static bool Delete(int id)
		{
			return clsTestAppointmentData.deleteTestAppointmentById(id);
		}

		// crud end

		public bool Lock()
		{
			IsLocked = true;
			return (this.Update());
		}

		// delete test before test appointment
		//clsTest GetTestRelatedToIt()
		//{

		//}
	}
}
