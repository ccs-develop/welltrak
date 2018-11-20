using System;
using UIKit;
using Foundation;

namespace welltrak.iOS
{
    public static class OrientationUtility
    {
        public static void LockOrientation(UIInterfaceOrientationMask orientation)
        {
            var appdelegate = (AppDelegate) UIApplication.SharedApplication.Delegate;
            if(appdelegate != null)
            {
                //appdelegate.OrientationLock = orientation;
            }
        }

        public static void LockOrientation(UIInterfaceOrientationMask orientation, UIInterfaceOrientation RotateToOrientation)
        {
            LockOrientation(orientation);

            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)RotateToOrientation), new NSString("orientation"));
        }

        internal static void ResetToDefault()
        {
            var appdelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            //LockOrientation(appdelegate.OrientationDefault);
        }   
    }
}
