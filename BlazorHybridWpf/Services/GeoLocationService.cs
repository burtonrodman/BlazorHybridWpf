using RazorClassLibrary1.Services;
using Windows.Devices.Geolocation;

namespace BlazorHybridWpf.Services
{
    internal class GeoLocationService : IGeoLocationService
    {
        public async Task<GeoPosition> GetPosition()
        {
            var locator = new Geolocator();
            var position = await locator.GetGeopositionAsync();
            return new GeoPosition()
            {
                Latitude = position.Coordinate.Latitude,
                Longitude = position.Coordinate.Longitude
            };
        }
    }
}
