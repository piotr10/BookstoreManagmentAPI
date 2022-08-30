using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.ValueObjects;

public class Adres : ValueObject
{
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int HouseNumber { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ApartmentNumber;
        yield return City;
        yield return Country;
        yield return HouseNumber;
        yield return Street;
        yield return ZipCode;
    }
}