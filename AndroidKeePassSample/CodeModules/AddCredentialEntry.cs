/*
 * Created by Ranorex
 * User: renzinger
 * Date: 24.01.2013
 * Time: 16:41
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
    /// Description of AddCredentialEntry.
    /// </summary>
    [TestModule("6A8CAA97-5C22-4EFC-9A0F-84F8356F2EF9", ModuleType.UserCode, 1)]
    public class AddCredentialEntry : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCredentialEntry()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _varTitle = "WordPressDemo";
        [TestVariable("B823466B-1E54-4BE6-8873-7E46B2ABB196")]
        public string varTitle
        {
        	get { return _varTitle; }
        	set { _varTitle = value; }
        }
        
        string _varUsername = "admin";
        [TestVariable("EE45E02B-423A-491C-9FDC-FC2A770E1D7B")]
        public string varUsername
        {
        	get { return _varUsername; }
        	set { _varUsername = value; }
        }
        
        string _varPassword = "demo123";
        [TestVariable("EFB35E5C-6BDA-4AE7-ACDD-185EFF7D6B71")]
        public string varPassword
        {
        	get { return _varPassword; }
        	set { _varPassword = value; }
        }
        
        
        string _varIconIndex = "12";
        [TestVariable("F28667A6-5A0D-47EF-A1FA-1B7AB0CD894E")]
        public string varIconIndex
        {
        	get { return _varIconIndex; }
        	set { 
        		_varIconIndex = value; 
        		AndroidKeePassSampleRepository.Instance.varIconIndexRepo = value;
        	}
        }
        
                
        string _varURL = "http://bitly.com/wp_demo";
        [TestVariable("0A49A36C-3365-4AF5-AA53-15DCDBC1159C")]
        public string varURL
        {
        	get { return _varURL; }
        	set { _varURL = value; }
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
            
             // Instance of Repository
            AndroidKeePassSampleRepository repo = AndroidKeePassSampleRepository.Instance;
                        
            // Touch category 'Internet'
            Report.Info ("Touch category 'Internet'");
            repo.ComAndroidKeepass.GroupActivity.Internet.Touch();
            
            Ranorex.Delay.Milliseconds(500);
            
            // Touch button 'Add'
            Report.Info ("Touch button 'Add'");
            repo.ComAndroidKeepass.GroupActivity.AddEntry.Touch();
            
            Ranorex.Delay.Milliseconds(500);
            
            // Set text-attribute of item 'Title'
            Report.Info ("Set text-attribute of item 'Title'");
            repo.ComAndroidKeepass.EntryActivity.TextFields.EntryTitle.TextValue = varTitle;
            
            Ranorex.Delay.Milliseconds(500);
            
            // Touch button 'Icon'
            Report.Info ("Touch button 'Icon'");
            repo.ComAndroidKeepass.EntryActivity.IconButton.Touch();
            
            Ranorex.Delay.Milliseconds(1500);
           
            // Touch 'Icon' to select it
            Report.Info ("Touch 'Icon'");
            repo.ComAndroidKeepass.IconImage.Touch();
            
            // Set text-attribute of item 'Username'
            Report.Info ("Set text-attribute of item 'Username'");
            repo.ComAndroidKeepass.EntryActivity.TextFields.EntryUserName.TextValue = varUsername;
            
            Ranorex.Delay.Milliseconds(500);
            
             // Set text-attribute of item 'URL'
            Report.Info ("Set text-attribute of item 'URL'");
            repo.ComAndroidKeepass.EntryActivity.TextFields.EntryUrl.TextValue = varURL;

            Ranorex.Delay.Milliseconds(500);
            
            // Set text-attribute of item 'Password'
            Report.Info ("Set text-attribute of item 'Password'");
            repo.ComAndroidKeepass.EntryActivity.TextFields.EntryPassword.TextValue = varPassword;
            
			Ranorex.Delay.Milliseconds(500);
            
            // Set text-attribute of item 'Confirm Password'
            Report.Info ("Set text-attribute of item 'Confirm Password'");
            repo.ComAndroidKeepass.EntryActivity.TextFields.EntryConfpassword.TextValue = varPassword;
           
            Ranorex.Delay.Milliseconds(1500);
            
             // Take Screenshot and send to Report
            Ranorex.Report.Screenshot (repo.ComAndroidKeepass.EntryActivity.Self);
            
            Ranorex.Delay.Milliseconds(500);
            
            // Touch button 'Save'
            Report.Info ("Touch button 'Save'");
            repo.ComAndroidKeepass.EntryActivity.Save.Touch();

        }
    }
}
