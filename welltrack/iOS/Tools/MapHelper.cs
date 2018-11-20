using System;
using System.Threading.Tasks;
using CoreLocation;

namespace welltrak.iOS.Tools
{
    public class MapHelper
    {
		public double MilesToLatitudeDegrees(double miles)
		{
			double earthRadius = 3960.0; // in miles
			double radiansToDegrees = 180.0 / Math.PI;
			return (miles / earthRadius) * radiansToDegrees;
		}

		public double MilesToLongitudeDegrees(double miles, double atLatitude)
		{
			double earthRadius = 3960.0; // in miles
			double degreesToRadians = Math.PI / 180.0;
			double radiansToDegrees = 180.0 / Math.PI;
			// derive the earth's radius at that point in latitude
			double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
			return (miles / radiusAtLatitude) * radiansToDegrees;
		}

		//Address to Coordinates
		async Task<CLPlacemark[]> GeocodeAsync(string address)
		{
			var geoCoder = new CLGeocoder();
			var placemarks = await geoCoder.GeocodeAddressAsync(address);
			return placemarks;
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
