﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace AndroidKeePassSample.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseApp recording.
    /// </summary>
    [TestModule("4a413563-1cc6-48ac-9dbd-bf308f2f8909", ModuleType.Recording, 1)]
    public partial class CloseApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AndroidKeePassSample.AndroidKeePassSampleRepository repository.
        /// </summary>
        public static global::AndroidKeePassSample.AndroidKeePassSampleRepository repo = global::AndroidKeePassSample.AndroidKeePassSampleRepository.Instance;

        static CloseApp instance = new CloseApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseApp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseApp Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ComAndroidKeepass'.", repo.ComAndroidKeepass.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.ComAndroidKeepass.Self, new Duration(0));
            Delay.Milliseconds(1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
