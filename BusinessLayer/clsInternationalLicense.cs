using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = false;
            CreatedByUserID = -1;
        }

        public clsInternationalLicense(
            int internationalLicenseID,
            int applicationID,
            int driverID,
            int issuedUsingLocalLicenseID,
            DateTime issueDate,
            DateTime expirationDate,
            bool isActive,
            int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }

        public static DataTable GetAll()
        {
            DataTable dt = DataAccessLayer.clsInternationalLicensesData.GetAll();
            if (dt == null)
                throw new Exception("Failed to retrieve international licenses.");
            return dt;
        }

        public static clsInternationalLicense GetByID(int internationalLicenseID)
        {
            var data = DataAccessLayer.clsInternationalLicensesData.GetByID(internationalLicenseID);
            if (data.InternationalLicenseID == -1)
                throw new Exception("International license not found.");
            return new clsInternationalLicense(
                data.InternationalLicenseID,
                data.ApplicationID,
                data.DriverID,
                data.IssuedUsingLocalLicenseID,
                data.IssueDate,
                data.ExpirationDate,
                data.IsActive,
                data.CreatedByUserID
            );
        }

        public void Add()
        {
            int id = DataAccessLayer.clsInternationalLicensesData.Add(new clsInternationalLicensesData.stInternationalLicense(
                InternationalLicenseID,
                ApplicationID,
                DriverID,
                IssuedUsingLocalLicenseID,
                IssueDate,
                ExpirationDate,
                IsActive,
                CreatedByUserID
            ));
            if (id == -1)
                throw new Exception("Failed to add international license.");
            InternationalLicenseID = id;
        }

        public void Update()
        {
            bool result = DataAccessLayer.clsInternationalLicensesData.Update(new clsInternationalLicensesData.stInternationalLicense(
                InternationalLicenseID,
                ApplicationID,
                DriverID,
                IssuedUsingLocalLicenseID,
                IssueDate,
                ExpirationDate,
                IsActive,
                CreatedByUserID
            ));
            if (!result)
                throw new Exception("Failed to update international license.");
        }

        public static void Delete(int internationalLicenseID)
        {
            bool result = DataAccessLayer.clsInternationalLicensesData.Delete(internationalLicenseID);
            if (!result)
                throw new Exception("Failed to delete international license.");
        }

        public void Delete()
        {
            Delete(InternationalLicenseID);
        }
    }
}