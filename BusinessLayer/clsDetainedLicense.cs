using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
	public class clsDetainedLicense
	{
		public int DetainID { get; set; }
		public int LicenseID { get; set; }
		public DateTime DetainDate { get; set; }
		public decimal FineFees { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsReleased { get; set; }
		public DateTime ReleaseDate { get; set; }
		public int ReleasedByUserID { get; set; }
		public int ReleaseApplicationID { get; set; }

		public clsDetainedLicense()
		{
			DetainID = -1;
			LicenseID = -1;
			DetainDate = DateTime.MinValue;
			FineFees = 0;
			CreatedByUserID = -1;
			IsReleased = false;
			ReleaseDate = DateTime.MinValue;
			ReleasedByUserID = -1;
			ReleaseApplicationID = -1;
		}

		public clsDetainedLicense(
			int detainID,
			int licenseID,
			DateTime detainDate,
			decimal fineFees,
			int createdByUserID,
			bool isReleased,
			DateTime releaseDate,
			int releasedByUserID,
			int releaseApplicationID)
		{
			DetainID = detainID;
			LicenseID = licenseID;
			DetainDate = detainDate;
			FineFees = fineFees;
			CreatedByUserID = createdByUserID;
			IsReleased = isReleased;
			ReleaseDate = releaseDate;
			ReleasedByUserID = releasedByUserID;
			ReleaseApplicationID = releaseApplicationID;
		}

		public static DataTable GetAll()
		{
			DataTable dt = clsDetainedLicenseData.GetAll();
			if (dt == null)
				throw new Exception("Failed to retrieve detained licenses.");
			return dt;
		}

		public static clsDetainedLicense GetByID(int detainID)
		{
			var data = clsDetainedLicenseData.GetByID(detainID);
			if (data.DetainID == -1)
				throw new Exception("Detained license not found.");
			return new clsDetainedLicense(
				data.DetainID,
				data.LicenseID,
				data.DetainDate,
				data.FineFees,
				data.CreatedByUserID,
				data.IsReleased,
				data.ReleaseDate,
				data.ReleasedByUserID,
				data.ReleaseApplicationID
			);
		}

		public static clsDetainedLicense GetByLicenseID(int LicenseID)
		{
			var data = clsDetainedLicenseData.GetByLicenseID(LicenseID);
			if (data.DetainID == -1)
				return null;
			return new clsDetainedLicense(
				data.DetainID,
				data.LicenseID,
				data.DetainDate,
				data.FineFees,
				data.CreatedByUserID,
				data.IsReleased,
				data.ReleaseDate,
				data.ReleasedByUserID,
				data.ReleaseApplicationID
			);
		}

		public void Add()
		{
			int id = clsDetainedLicenseData.Add(new clsDetainedLicenseData.stDetainedLicense(
				DetainID,
				LicenseID,
				DetainDate,
				FineFees,
				CreatedByUserID,
				IsReleased,
				ReleaseDate,
				ReleasedByUserID,
				ReleaseApplicationID
			));
			if (id == -1)
				throw new Exception("Failed to add detained license.");
			DetainID = id;
		}

		/// <exception cref="Exception"></exception>
		public void Update()
		{
			bool result = clsDetainedLicenseData.Update(new clsDetainedLicenseData.stDetainedLicense(
				DetainID,
				LicenseID,
				DetainDate,
				FineFees,
				CreatedByUserID,
				IsReleased,
				ReleaseDate,
				ReleasedByUserID,
				ReleaseApplicationID
			));
			if (!result)
				throw new Exception("Failed to update detained license.");
		}

		public static bool Delete(int detainID)
		{
			bool result = clsDetainedLicenseData.Delete(detainID);
			if (!result)
				throw new Exception("Failed to delete detained license.");
			return result;
		}

		public bool Delete()
		{
			return Delete(DetainID);
		}
	}
}