using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using com.Goval.Mobile.Primus.Core.DependecyServices;
using Xamarin.Forms;
using com.Goval.Mobile.Primus.Droid.DependencyService;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformVIsualElements))]
namespace com.Goval.Mobile.Primus.Droid.DependencyService
{
    class PlatformVIsualElements : IPlatformVIsualElements
    {
        public void HideStatusBar()
        {
            var activity = (Activity)Forms.Context;
            activity.Window.AddFlags(WindowManagerFlags.Fullscreen);
            activity.Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);


            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                // Kill status bar underlay added by FormsAppCompatActivity
                var statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (statusBarHeightInfo == null)
                {
                    statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("_statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                }
                statusBarHeightInfo?.SetValue(activity, 0);
            }
        }

        public void ShowStatusBar()
        {
            var activity = (Activity)Forms.Context;
            activity.Window.AddFlags(WindowManagerFlags.ForceNotFullscreen);
            activity.Window.ClearFlags(WindowManagerFlags.Fullscreen);
            Xamarin.Forms.Forms.SetTitleBarVisibility(Xamarin.Forms.AndroidTitleBarVisibility.Default);

        }
    }
}