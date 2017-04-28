using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using com.Goval.Mobile.Primus.Core.DependecyServices;
using com.Goval.Mobile.Primus.iOS.DependencyService;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformVIsualElements))]
namespace com.Goval.Mobile.Primus.iOS.DependencyService
{
    class PlatformVIsualElements : IPlatformVIsualElements
    {
        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }
    }
}