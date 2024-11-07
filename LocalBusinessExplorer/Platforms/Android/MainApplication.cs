﻿using Android.App;
using Android.Runtime;
using Firebase; // Add this import

namespace LocalBusinessExplorer
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            // Initialize Firebase
            FirebaseApp.InitializeApp(this);
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}