namespace RazorClassLibrary1.Services
{
    public class GeoPosition
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public interface IGeoLocationService
    {
        Task<GeoPosition> GetPosition();
    }
}
