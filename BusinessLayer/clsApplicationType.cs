using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
	public class clsApplicationType
	{
		public int ApplicationTypeID { get; set; }
		public string ApplicationTypeTitle { get; set; }
		public decimal ApplicationFees { get; set; }

		public clsApplicationType()
		{
			ApplicationTypeID = -1;
			ApplicationTypeTitle = string.Empty;
			ApplicationFees = -1;
		}

		clsApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
		{
			ApplicationTypeID = applicationTypeID;
			ApplicationTypeTitle = applicationTypeTitle;
			ApplicationFees = applicationFees;
		}

		static public DataTable	getAllApplicationTypes()
		{
			return clsApplicationTypeData.getAllApplicationTypes();
		}

		static public clsApplicationType getApplicationTypeById(int id)
		{
			clsApplicationTypeData.stApplicationType applicationType = clsApplicationTypeData.getApplicationTypeById(id);
			if (applicationType.ApplicationTypeID == -1)
				return null;
			else
				return new clsApplicationType(applicationType.ApplicationTypeID,
						applicationType.ApplicationTypeTitle, applicationType.ApplicationFees);
		}

		bool	update()
		{
			return clsApplicationTypeData.updateApplicationType(
				new clsApplicationTypeData.stApplicationType(
					ApplicationTypeID, ApplicationTypeTitle, ApplicationFees));
		}
	}
}
