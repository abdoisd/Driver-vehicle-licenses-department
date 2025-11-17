using BusinessLayer;
using FullRealProject.People.Forms;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace FullRealProject.People.Controls
{
	public partial class uCtlShowPerson : UserControl
	{
		// data
		clsPerson person = new clsPerson();

		public bool	fromPerson(int id)
		{
			person = clsPerson.getPersonById(id);
			if (person == null)
			{
				MessageBox.Show($"Person {id} Not found");
				return false;
			}

			lblPersonID.Text = person.PersonID.ToString();
			lblFullName.Text = person.FirstName + " " + person.LastName;
			lblNationalNo.Text = person.NationalNo;
			if (person.Gender == 0)
				lblGendor.Text = "Male";
			else
				lblGendor.Text = "Female";
			lblEmail.Text = person.Email;
			lblAddress.Text = person.Address;
			lblDateOfBirth.Text = person.DateOfBirth.ToString();
			lblPhone.Text = person.Phone;
			lblCountry.Text = clsCountry.getCountryByID(person.NationalityCountryID).CountryName;
			pbPersonImage.ImageLocation = person.ImagePath;

			return true;
		}
		//

		public uCtlShowPerson()
		{
			InitializeComponent();
		}

		private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson(person.PersonID);
			frm.ShowDialog();
			fromPerson(person.PersonID);
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{

		}
	}
}
