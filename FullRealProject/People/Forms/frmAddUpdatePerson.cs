using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace FullRealProject.People.Forms
{
	public partial class frmAddUpdatePerson : Form
	{
		public delegate void DataBackEventHandler(object sender, int PersonID);
		public event DataBackEventHandler DataBack;
		//

		// data
		enum enMode
		{
			Add,
			Update
		}

		enMode eMode;

		clsPerson person = new clsPerson();

		void fromPerson(clsPerson person)
		{
			txtNationalNo.Text = person.NationalNo;
			txtFirst.Text = person.FirstName;
			txtSecond.Text = person.SecondName;
			txtThird.Text = person.ThirdName;
			txtLast.Text = person.LastName;
			txtAddress.Text = person.Address;
			txtEmail.Text = person.Email;
			txtPhone.Text = person.Phone;

			dtpDateOfBirth.Value = person.DateOfBirth;
			cbCountry.Text = clsCountry.getCountryByID(person.NationalityCountryID).CountryName;
			if (person.Gender == 1)
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;
			pbPersonImage.ImageLocation = person.ImagePath;
		}

		void setPerson() // set this.person
		{
			Byte gender = 1;
			if (rbFemale.Checked)
				gender = 0;

			// the id will stay the same
			person.NationalNo = txtNationalNo.Text;
			person.FirstName = txtFirst.Text;
			person.SecondName = txtSecond.Text;
			person.ThirdName = txtThird.Text;
			person.LastName = txtLast.Text;
			person.Email = txtEmail.Text;
			person.Phone = txtPhone.Text;
			person.Address = txtAddress.Text;

			person.ImagePath = pbPersonImage.ImageLocation;
			person.NationalityCountryID = (int)((DataRowView)cbCountry.SelectedItem)["CountryID"];
			person.Gender = gender;
			person.DateOfBirth = dtpDateOfBirth.Value;
		}
		//

		public frmAddUpdatePerson() // add mode
		{
			InitializeComponent();

			eMode = enMode.Add;
			lblTitle.Text = "Adding New Person";
		}

		public frmAddUpdatePerson(int id) // update mode
		{
			InitializeComponent();

			eMode = enMode.Update;
			lblTitle.Text = "Updating Person";
			person = clsPerson.getPersonById(id);
			fromPerson(person);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmAddUpdatePerson_Load(object sender, EventArgs e)
		{
			// dtp
			dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
			dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

			// cb
			cbCountry.DataSource = clsCountry.getAllCountries();
			cbCountry.DisplayMember = "CountryName";
			cbCountry.ValueMember = "CountryID";

			// pb
			if (eMode == enMode.Add)
			{
				pbPersonImage.ImageLocation = "";
				pbPersonImage.Image = Properties.Resources.Male_512;
			}
			pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
		}

		private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (ofdSetImage.ShowDialog() == DialogResult.OK)
				pbPersonImage.ImageLocation = ofdSetImage.FileName;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (eMode == enMode.Add)
			{
				setPerson();
				person.add();
				if (person.PersonID != -1)
					MessageBox.Show($"Person: {person.PersonID} Added Successfully");
				else
					MessageBox.Show("Failure adding person");
				DataBack?.Invoke(sender, person.PersonID);

				// switch to update
				eMode = enMode.Update;
				lblTitle.Text = "Updating Person";
			}
			else if (eMode == enMode.Update)
			{
				setPerson(); // the id will stay with it
				if (person.update())
					MessageBox.Show($"Person: {person.PersonID} Updated Successfully");
				else
					MessageBox.Show("Failure updating person");
			}
		}
	}
}
