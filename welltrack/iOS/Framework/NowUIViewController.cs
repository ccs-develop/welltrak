//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Foundation;
//using Newtonsoft.Json;
//using SBMobile.Services;
//using SmartBen.Api.Model.Enums;
//using SmartBen.Api.Model.Models.Requests;
//using UIKit;

//namespace SBMobile.iOS.Framework
//{
//    public class NowUIViewController : UIViewController
//    {
//        protected NowUIViewController(IntPtr handle) : base(handle)
//        {
//        }

//        public override void ViewDidAppear(bool animated)
//        {
//            AnalyticsService.GetAnalyticsServiceInstance().Track_App_Page(this.GetType().Name.Replace("Controller", string.Empty));
//            base.ViewDidAppear(animated);
//        }


//    }

//    public static class EventHelper
//    {
//        public static void TrackEvent(Features feature, EventSourceType? eventSourceType, EventActionType? eventActionType)
//        {
//            var eventCacheTag = "event_cache";
//            EventsRequest eventsRequest;
//            //see if we have any stored.
//            var eventCache = GetUserSettingString(eventCacheTag);
//            if (string.IsNullOrWhiteSpace(eventCache))
//                eventsRequest = SBMobile.UserService.Instance.NewRequest<EventsRequest>();
//            else
//                eventsRequest = JsonConvert.DeserializeObject<EventsRequest>(eventCache);

//            var newEvent = SBMobile.UserService.Instance.NewRequest<EventRequest>();
//            newEvent.EventSourceType = eventSourceType;
//            newEvent.EventActionType = eventActionType;
//            newEvent.EventTime = DateTime.Now;
//            newEvent.Feature = feature;

//            eventsRequest.Events.Add(newEvent);

//            Task.Run(async () =>
//            {
//                if (eventsRequest.Events.Count >= SBMobile.UserService.Instance.EventBatchSize && HasConnection())
//                {
//                    var clear = await LogService.Event(eventsRequest);
//                    if (clear)
//                    {
//                        SetUserSettingString(eventCacheTag, string.Empty);
//                    }
//                }
//                else
//                {
//                    eventCache = JsonConvert.SerializeObject(eventsRequest);
//                    SetUserSettingString(eventCacheTag, eventCache);
//                }
//            }).Wait();

//        }

//        public static bool HasConnection()
//        {
//            return Reachability.RemoteHostStatus() != NetworkStatus.NotReachable;
//        }

//        private static void SetUserSettingString(string tag, string value)
//        {
//            NSUserDefaults.StandardUserDefaults.SetString(value, tag);
//            NSUserDefaults.StandardUserDefaults.Synchronize();
//        }
//        private static string GetUserSettingString(string tag)
//        {
//            var value = NSUserDefaults.StandardUserDefaults.StringForKey(tag);
//            return value;
//        }
//    }
//}