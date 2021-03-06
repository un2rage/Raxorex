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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("0188344a-aa14-46a6-8679-b6ec1ad8185e", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrimeServiceRepository repository.
        /// </summary>
        public static PrimeServiceRepository repo = PrimeServiceRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            Value = "";
            Result = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Value;

        /// <summary>
        /// Gets or sets the value of variable Value.
        /// </summary>
        [TestVariable("79db8063-0122-465f-a426-88bd39ee073a")]
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        string _Result;

        /// <summary>
        /// Gets or sets the value of variable Result.
        /// </summary>
        [TestVariable("3a48ff13-5579-47ce-942e-e41cdd12ebc5")]
        public string Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.Text' at 161;11.", repo.Form1.TextInfo, new RecordItemIndex(0));
            repo.Form1.Text.Click("161;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Value' with focus on 'Form1.Text'.", repo.Form1.TextInfo, new RecordItemIndex(1));
            repo.Form1.Text.PressKeys(Value);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.Button1' at 61;13.", repo.Form1.Button1Info, new RecordItemIndex(2));
            repo.Form1.Button1.Click("61;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Result) on item 'Form1.Label2'.", repo.Form1.Label2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Form1.Label2Info, "Text", Result);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
