using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
	public class clsTestType
	{
		public enum enTestTypes
		{
			Vision = 1,
			Written,
			Street
		}

		public enTestTypes TestTypeID { get; set; }
		public string TestTypeTitle { get; set; }
		public string TestTypeDescription { get; set; }
		public decimal TestTypeFees { get; set; }

		static public DataTable getAllTestTypes()
		{
			return clsTestTypeData.getAllTestTypes();
		}

		static public clsTestType getByID(int testTypeID)
		{
			if (testTypeID == -1)
				return null;
			else
			{
				var testTypeData = clsTestTypeData.getTestTypeById(testTypeID);
				if (testTypeData.TestTypeID == -1)
					return null;
				return new clsTestType()
				{
					TestTypeID = (clsTestType.enTestTypes)testTypeData.TestTypeID,
					TestTypeTitle = testTypeData.TestTypeTitle,
					TestTypeDescription = testTypeData.TestTypeDescription,
					TestTypeFees = testTypeData.TestTypeFees
				};
			}
		}

		public bool update()
		{
			return clsTestTypeData.updateTestType(new clsTestTypeData.stTestType((int)this.TestTypeID,
				this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees));
		}
	}
}
