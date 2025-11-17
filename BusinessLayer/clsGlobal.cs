using BusinessLayer;

namespace FullRealProject
{
	public static class clsGlobal
	{
		public static clsUser loggedInUser = clsUser.getUserById(1);
		public static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
		public static string sourceName = "FullRealProject";
	}
}
