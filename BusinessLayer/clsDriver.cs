using System;
using System.Data;
using System.Runtime.CompilerServices;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsDriver
	{
		public int DriverID { get; set; }
		public int PersonID { get; set; }
		public int CreatedByUserID { get; set; }
		public DateTime CreatedDate { get; set; }

		public clsDriver()
		{
			DriverID = -1;
			PersonID = -1;
			CreatedByUserID = -1;
			CreatedDate = DateTime.MinValue;
		}

		public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
		{
			DriverID = driverID;
			PersonID = personID;
			CreatedByUserID = createdByUserID;
			CreatedDate = createdDate;
		}

		/// <exception cref="Exception"></exception>
		public static DataTable GetAllDrivers()
		{
			var dt = clsDriverData.getAllDrivers();
			if (dt == null)
				throw new Exception("Failed to retrieve drivers.");
			return dt;
		}

		/// <exception cref="Exception"></exception>
		public static clsDriver GetDriverByID(int driverID)
		{
			var data = clsDriverData.getDriverByID(driverID);
			if (data.DriverID == -1)
				throw new Exception("Driver not found.");
			return new clsDriver
			{
				DriverID = data.DriverID,
				PersonID = data.PersonID,
				CreatedByUserID = data.CreatedByUserID,
				CreatedDate = data.CreatedDate
			};
		}

		/// <exception cref="Exception"></exception>
		public void Add()
		{
			var st = new clsDriverData.stDriver(
				0,
				this.PersonID,
				this.CreatedByUserID,
				this.CreatedDate
			);
			int id = clsDriverData.addDriver(st);
			this.DriverID = id;
			if (id <= 0)
				throw new Exception("Failed to add driver.");
		}

		/// <exception cref="Exception"></exception>
		public void Update()
		{
			var st = new clsDriverData.stDriver(
				this.DriverID,
				this.PersonID,
				this.CreatedByUserID,
				this.CreatedDate
			);
			bool result = clsDriverData.updateDriver(st);
			if (!result)
				throw new Exception("Failed to update driver.");
		}

		/// <exception cref="Exception"></exception>
		public void Delete()
		{
			bool result = clsDriverData.deleteDriverById(this.DriverID);
			if (!result)
				throw new Exception("Failed to delete driver.");
		}

		/// <exception cref="Exception"></exception>
		public static void DeleteDriverById(int driverID)
		{
			bool result = clsDriverData.deleteDriverById(driverID);
			if (!result)
				throw new Exception("Failed to delete driver.");
		}

		// get local
		public DataTable GetLocalLicenses()
		{
			return clsLicenseData.getAllLicensesByDriverID(this.DriverID);
		}

		// get international
	}
}