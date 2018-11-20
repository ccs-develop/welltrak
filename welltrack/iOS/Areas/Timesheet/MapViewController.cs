using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;
using CoreGraphics;
using System.Threading.Tasks;
using welltrak.iOS.Tools;


namespace welltrak.iOS
{
    public partial class MapViewController : UIViewController
    {
        MapHelper MapHelper = new MapHelper();
        MKCircle circleOverlay;
        MKCircleRenderer circleRenderer;
        CLLocationCoordinate2D targetCoords;
        CLLocationCoordinate2D userLocation;

        public MapViewController(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.Title = "Geo Clock In";
        }

        public override async void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

			NavigationController.SetNavigationBarHidden(false, true);

            WelltrakAppService.Instance.CurrentTargetAddress = WelltrakAppService.Instance.CurrentAppointment.Client.Address.GetAddressLineString();

            var targetLocation = await GeocodeAsync(WelltrakAppService.Instance.CurrentTargetAddress);
            targetCoords = targetLocation[0].Location.Coordinate;

            var mapView = (MKMapView)View.ViewWithTag(80);

            if (mapView == null)
            {
                var locationManager = new CLLocationManager();

                locationManager.RequestWhenInUseAuthorization();



                ///MAP VIEW ///
                var w = this.View.Frame.Width * .70;
                var offset = this.View.Frame.Width * .15;
                mapView = new MKMapView(new CGRect(offset, offset * 2, w, w))
                {
                    Tag = 80,
                    ShowsUserLocation = true,
                    MapType = MapKit.MKMapType.Standard,
                    ZoomEnabled = false,
                    ScrollEnabled = false
                };

                //mapView.Layer.CornerRadius = (float)w / 2;

                mapView.OverlayRenderer = (m, o) =>
                {
                    if (circleRenderer == null)
                    {
                        circleRenderer = new MKCircleRenderer(o as MKCircle);
                        circleRenderer.FillColor = UIColor.Green;
                        circleRenderer.Alpha = 0.5f;
                    }
                    return circleRenderer;
                };

                mapView.DidUpdateUserLocation += (sender, e) =>
                {
                    if (mapView.UserLocation != null)
                    {
                        CLLocationCoordinate2D coords = targetCoords;
                        MKCoordinateSpan span = new MKCoordinateSpan(MapHelper.MilesToLatitudeDegrees(2), MapHelper.MilesToLongitudeDegrees(2, coords.Latitude));
                        mapView.Region = new MKCoordinateRegion(coords, span);
                        userLocation = mapView.UserLocation.Coordinate;
                        CheckDistance();
                    }
                };

                if (mapView.UserLocation != null)
                {

                }

                if (!mapView.UserLocationVisible)
                {
                    // user denied permission, or device doesn't have GPS/location ability
                    CLLocationCoordinate2D coords = new CLLocationCoordinate2D(37.33233141, -122.0312186); // cupertino
                    MKCoordinateSpan span = new MKCoordinateSpan(MapHelper.MilesToLatitudeDegrees(8), MapHelper.MilesToLongitudeDegrees(8, coords.Latitude));
                    mapView.Region = new MKCoordinateRegion(coords, span);
                }

                View.AddSubview(mapView);
                View.BringSubviewToFront(mapView);

                //Draw the Target Circle Area
                circleOverlay = MKCircle.Circle(targetCoords, 500);
                mapView.AddOverlay(circleOverlay);
            }


        }

        void CheckDistance()
        {
            var label1 = (UILabel)this.View.ViewWithTag(81);
            if (label1 == null)
            {
                label1 = new UILabel();
                label1.Tag = 81;
                label1.Lines = 2;
                label1.Frame = new CGRect(5, this.View.Bounds.Height / 2 + 50, this.View.Bounds.Width, 15);
                View.AddSubview(label1);
            }

            var t = new CLLocation(targetCoords.Latitude, targetCoords.Longitude);
            var u = new CLLocation(userLocation.Latitude, userLocation.Longitude);
            var distanceToTarget = t.DistanceFrom(u);

            var closeEnough = false;
            if (distanceToTarget <= 500)
            {
                closeEnough = true;
            }

            label1.Text = $"Dist_m: {distanceToTarget.ToString("N0")} Close: {closeEnough.ToString()}";
            if (closeEnough)
            {
                EnableLoginButton();
            }
        }

        private void EnableLoginButton()
        {
            var btn = (UIButton)this.View.ViewWithTag(82);
            if (btn == null)
            {
                btn = new UIButton();
                var frame = new CGRect(this.View.Bounds.Width / 2 - 100, this.View.Bounds.Bottom - 200, 200, 50);
                btn.Frame = frame;
                btn.Layer.CornerRadius = 3;
                btn.BackgroundColor = UIColor.FromRGB(0, 119, 107);
                btn.SetTitle("Clock In", UIControlState.Normal);
                btn.TouchUpInside += delegate
                {
                    ClockIn();
                };
            }

            View.AddSubview(btn);
        }

        private void ClockIn()
        {
            this.PerformSegue("AppointmentOpsSegue", this);
        }


        //Address to Coordinates
        async Task<CLPlacemark[]> GeocodeAsync(string address)
        {
            try
            {
				var geoCoder = new CLGeocoder();
				var placemarks = await geoCoder.GeocodeAddressAsync(address);
				return placemarks;
            }
            catch (Exception ex)
            {
                return new CLPlacemark[]{
                    new CLPlacemark(new NSCoder())
                };
            }

        }

        //Coordinates to Address
        async Task<CLPlacemark[]> ReverseGeocodeAsync(CLLocation location)
        {
            var geoCoder = new CLGeocoder();
            var placemarks = await geoCoder.ReverseGeocodeLocationAsync(location);
            return placemarks;
        }
    }
}