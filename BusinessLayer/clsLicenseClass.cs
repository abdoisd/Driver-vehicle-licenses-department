using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
	public class clsLicenseClass
	{
		public int LicenseClassID { get; set; }
		public string ClassName { get; set; }
		public string ClassDescription { get; set; }
		public Byte MinimumAllowedAge { get; set; }
		public Byte DefaultValidityLength { get; set; }
		public decimal ClassFees { get; set; }

		public clsLicenseClass()
		{
			LicenseClassID = -1;
			ClassName = string.Empty;
			ClassDescription = string.Empty;
			MinimumAllowedAge = 0;
			DefaultValidityLength = 0;
			ClassFees = -1;
		}

		public clsLicenseClass(int licenseClassID, string className, string classDescription,
			Byte minimumAllowedAge, Byte defaultValidityLength, decimal classFees)
		{
			LicenseClassID = licenseClassID;
			ClassName = className;
			ClassDescription = classDescription;
			MinimumAllowedAge = minimumAllowedAge;
			DefaultValidityLength = defaultValidityLength;
			ClassFees = classFees;
		}

		static public DataTable getAllLicenseClasses()
		{
			return clsLicenseClassData.getAllLicenseClasses();
		}

		static public clsLicenseClass getLicenseClassById(int id)
		{
			var licenseClass = clsLicenseClassData.getLicenseClassById(id);
			if (licenseClass.LicenseClassID == -1)
				return null;
			else
				return new clsLicenseClass(licenseClass.LicenseClassID, licenseClass.ClassName, licenseClass.ClassDescription,
					licenseClass.MinimumAllowedAge, licenseClass.DefaultValidityLength, licenseClass.ClassFees);
		}
	}
}
