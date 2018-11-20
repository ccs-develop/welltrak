//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Foundation;
//using UIKit;
//using Google.Analytics;


//namespace SBMobile.iOS.Framework
//{
//    class AnalyticsService
//    {
//        public string TrackingId = Constants.iOSTrackingId;

//        public ITracker Tracker;
//        const string AllowTrackingKey = "AllowTracking";

//        #region Instantition...
//        private static AnalyticsService thisRef;
//        private AnalyticsService()
//        {
//            // no code req'd
//        }

//        public static AnalyticsService GetAnalyticsServiceInstance()
//        {
//            if (thisRef == null)
//                // it's ok, we can call this constructor
//                thisRef = new AnalyticsService();
//            return thisRef;
//        }
//        #endregion

//        public void Initialize()
//        {
//            var optionsDict = NSDictionary.FromObjectAndKey(new NSString("YES"), new NSString(AllowTrackingKey));
//            NSUserDefaults.StandardUserDefaults.RegisterDefaults(optionsDict);

//            Gai.SharedInstance.OptOut = !NSUserDefaults.StandardUserDefaults.BoolForKey(AllowTrackingKey);

//            Gai.SharedInstance.DispatchInterval = 10;
//            Gai.SharedInstance.TrackUncaughtExceptions = true;

//            Tracker = Gai.SharedInstance.GetTracker("SmartBen NOW iOS", TrackingId);
//        }

//        public void Track_App_Page(string PageNameToTrack)
//        {
//            Gai.SharedInstance.DefaultTracker.Set(GaiConstants.ScreenName, $"{Constants.environmentVar}.iOS.{PageNameToTrack}");
//            Gai.SharedInstance.DefaultTracker.Send(DictionaryBuilder.CreateScreenView().Build());
//        }

//        public void Track_App_Event(string GAEventCategory, string EventToTrack)
//        {
//            Gai.SharedInstance.DefaultTracker.Send(DictionaryBuilder.CreateEvent($"{Constants.environmentVar}.iOS.{GAEventCategory}", EventToTrack, "AppEvent", null).Build());
//            Gai.SharedInstance.Dispatch(); // Manually dispatch the event immediately
//        }

//        public void Track_App_Exception(string ExceptionMessageToTrack, bool isFatalException)
//        {
//            Gai.SharedInstance.DefaultTracker.Send(DictionaryBuilder.CreateException(ExceptionMessageToTrack, isFatalException).Build());
//        }
//    }
//}