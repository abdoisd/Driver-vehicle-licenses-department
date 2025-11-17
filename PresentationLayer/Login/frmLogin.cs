using BusinessLayer;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FullRealProject
{
	public partial class frmLogin : Form
	{
		// data
		private clsUser user;
		//

		public frmLogin()
		{
			InitializeComponent();

			//Console.WriteLine(Environment.CommandLine);
			MessageBox.Show(Environment.CommandLine);
			MessageBox.Show(Environment.UserInteractive.ToString());
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			user = clsUser.getUserByUsernameAndPassword(txtUsername.Text, txtPassword.Text);
			if (user == null)
			{
				MessageBox.Show("Invalid username or password.", "Login Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				EventLog.WriteEntry(clsGlobal.sourceName, "Invalid username or password.", EventLogEntryType.Warning);
				return;
			}
			else
			{
				if (!user.IsActive)
				{
					MessageBox.Show("Account inactive for now");
					return;
				}

				_handleRememberMe();

				clsGlobal.loggedInUser = user;
				Hide();
				frmMain frm = new frmMain(this);
				frm.Show();
			}
		}

		private void _handleRememberMe()
		{
			if (cbRemeberMe.Checked)
			{
				//try
				//{
				//	FileStream fileStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
				//	string fileContent = $"{txtUsername.Text}\n{txtPassword.Text}";
				//	byte[] bytes = System.Text.Encoding.UTF8.GetBytes(fileContent);
				//	fileStream.Write(bytes, 0, bytes.Length);
				//	fileStream.Close();
				//}
				//catch (Exception ex)
				//{
				//	MessageBox.Show("Error writing to file: " + ex.Message, "File Error",
				//		MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
				string value1Name = "UserName";
				string value1Data = txtUsername.Text;
				string value2Name = "UserPass";
				string value2Data = txtPassword.Text;

				try
				{
					// Write the value to the Registry
					Registry.SetValue(clsGlobal.keyPath, value1Name, value1Data, RegistryValueKind.String);
					Registry.SetValue(clsGlobal.keyPath, value2Name, value2Data, RegistryValueKind.String);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
			else
			{
				//try
				//{
				//	if (File.Exists("data.txt"))
				//		File.Delete("data.txt");
				//}
				//catch (Exception ex)
				//{
				//	MessageBox.Show("Error deleting file: " + ex.Message, "File Error",
				//		MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
				string value1Name = "UserName";
				string value1Data = "";
				string value2Name = "UserPass";
				string value2Data = "";
				try
				{
					Registry.SetValue(clsGlobal.keyPath, value1Name, value1Data, RegistryValueKind.String);
					Registry.SetValue(clsGlobal.keyPath, value2Name, value2Data, RegistryValueKind.String);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		private void _loadRememberedUser()
		{
			//if (File.Exists("data.txt"))
			//{
			//	try
			//	{
			//		StreamReader streamReader = File.OpenText("data.txt");
			//		txtUsername.Text = streamReader.ReadLine();
			//		txtPassword.Text = streamReader.ReadLine();
			//		cbRemeberMe.Checked = true;
			//		streamReader.Close();
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show("Error reading file: " + ex.Message,
			//			"File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
			try
			{
				string valueName1 = "UserName";
				string valueName2 = "UserPass";

				// Read the value from the Registry
				string value1 = Registry.GetValue(clsGlobal.keyPath, valueName1, null) as string;
				string value2 = Registry.GetValue(clsGlobal.keyPath, valueName2, null) as string;

				if (value1 != null && value2 != null)
				{
					txtUsername.Text = value1;
					txtPassword.Text = value2;
					if (value1 == "" && value2 == "")
						cbRemeberMe.Checked = false;
					else
						cbRemeberMe.Checked = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			_loadRememberedUser();

			// create place application entry in event viewer
			if (!EventLog.SourceExists(clsGlobal.sourceName))
			{
				EventLog.CreateEventSource(clsGlobal.sourceName, "Application");
				Console.WriteLine("Event source created.");
			}
		}

		private void frmLogin_Activated(object sender, EventArgs e)
		{
			txtUsername.Focus();
		}
	}
}
