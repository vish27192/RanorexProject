/*
 * Created by Ranorex
 * User: renzinger
 * Date: 24.01.2013
 * Time: 12:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AndroidKeePassSample
{
	/// <summary>
	/// Description of CreateDBOrJustLogin.
	/// </summary>
	[TestModule("B98F4E6D-7B2B-4CC9-8303-C5195A3C3409", ModuleType.UserCode, 1)]
	public class CreateDatabaseAndLogin : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CreateDatabaseAndLogin()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			
			AndroidKeePassSampleRepository repo = AndroidKeePassSampleRepository.Instance;
			
			// Preparing Filename for Database
			string fp = repo.ComAndroidKeepass.FileSelect.DatabaseFilename.TextValue;
			Ranorex.Report.Info ("Original filename: " + fp);
			string fn = System.IO.Path.GetFileName (fp);
			string db = fp.Replace (fn, "RanorexKeePass.kdb");
			
			
			// Set database filename
			Ranorex.Report.Info ("Set Database filename to "+db);
			repo.ComAndroidKeepass.FileSelect.DatabaseFilename.TextValue = db;
			
			Ranorex.Delay.Milliseconds(500);
			
			// Touch Button "Open"
			Ranorex.Report.Info ("Touch button to open database");
			repo.ComAndroidKeepass.FileSelect.Open.Touch();
			
			
			// Avoid waiting too long when asking the button "Open" for existence
			// Therefore use a redundant repo-item with reduced search-timeout
			// -> In case button still exists on current screen: Database does not exist yet, 
			//    so create new one with given filename
			
			Ranorex.Report.Info ("Find out if Database exists");
			
			if (!repo.PasswordInformation_ShortSearchTimeoutInfo.Exists(Duration.FromMilliseconds(5000)))
			{
				Ranorex.Report.Info ("Database does not exist");
				
				// Open did not work because Database does not exist yet - so just create new Database!
				Ranorex.Report.Info ("Touch button to create new database");
				repo.ComAndroidKeepass.FileSelect.CreateDatabase.Touch();
				
				Ranorex.Delay.Milliseconds(500);
				
				// Set Password
				Ranorex.Report.Info ("Set text-attribute in password control");
				repo.ComAndroidKeepass.CreateDatabase.PassPassword.TextValue = "rx";
				
				Ranorex.Delay.Milliseconds(500);
				
				// Repeat Password
				Ranorex.Report.Info ("Set text-attribute in password repeat control");
				repo.ComAndroidKeepass.CreateDatabase.PassConfPassword.TextValue = "rx";
				
				Ranorex.Delay.Milliseconds(500);
				
				// Confirm Value - Jump to next field
				Ranorex.Report.Info ("PressKey ENTER");
				repo.ComAndroidKeepass.Self.PressKeys("{ENTER}");
				
				Ranorex.Delay.Milliseconds(500);
				
				// Confirm Value - Jump to next field
				Ranorex.Report.Info ("PressKey ENTER");
				repo.ComAndroidKeepass.Self.PressKeys("{ENTER}");
				
				Ranorex.Delay.Milliseconds(500);
				
				// Confirm Value - Jump to next field
				Ranorex.Report.Info ("PressKey ENTER");
				repo.ComAndroidKeepass.Self.PressKeys("{ENTER}");
				
				Ranorex.Delay.Milliseconds(500);
				
				// Still need to confirm dialog? One more ENTER?
				if (repo.btOK_ShortSearchTimeoutInfo.Exists ())
				{
					Ranorex.Report.Info ("PressKey ENTER");
					repo.ComAndroidKeepass.Self.PressKeys("{ENTER}");
				}
			}
			else
			{
				// Open database worked - Just log into existing database
				Ranorex.Report.Info ("Do log in");
				
				// Set password
				Ranorex.Report.Info ("Set text-attribute in password control");
				repo.ComAndroidKeepass.PasswordActivity.Password.Element.SetAttributeValue("Text", "rx");
				
				// Confirm dialog
				Ranorex.Report.Info ("Touch button OK");
				repo.ComAndroidKeepass.PasswordActivity.ButtonOK.Touch();
			}
			
		}
	}
}
