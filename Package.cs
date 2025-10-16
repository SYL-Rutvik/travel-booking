using System.Collections.Generic;
using travel_booking;

namespace travel_booking
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public decimal PricePerPerson { get; set; } 
        public string PackageType { get; set; }
        public string Description { get; set; }      // Add this
        public int DurationDays { get; set; }        // Add this
    }
}

public class PackageRepository
{
    public List<Package> GetTopPackages(int numberOfPackages)
    {
        string query = $"SELECT TOP {numberOfPackages} PackageId, PackageName, Description, PricePerPerson, DurationDays FROM Packages";

        // Placeholder for actual database interaction logic
        // For now, return an empty list to ensure all code paths return a value
        return new List<Package>();
    }
}
