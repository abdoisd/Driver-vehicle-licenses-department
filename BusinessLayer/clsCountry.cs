using System.Data;
using static DataAccessLayer.clsCountryData;

namespace BusinessLayer
{
	public class clsCountry
	{
		public int CountryId { get; set; }
		public string CountryName { get; set; }

		clsCountry(int countryId, string countryName)
		{
			CountryId = countryId;
			CountryName = countryName;
		}

		public static DataTable getAllCountries()
		{
			return DataAccessLayer.clsCountryData.getAllCountries();
		}

		public static clsCountry getCountryByID(int id)
		{
			stCountry country = DataAccessLayer.clsCountryData.getCountryByID(id);
			if (country.CountryId == -1)
				return null;
			else
				return new clsCountry(country.CountryId, country.CountryName);
		}
	}
}
