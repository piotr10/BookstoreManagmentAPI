namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class CustomerDetailVm
{
    public string Name { get; set; } //CustomerDetail>FirstName
    public string Surname { get; set; } //CustomerDetail>LastName
    public string DetailContact { get; set; } //CustomerDetail>DetailContact
    public string DetailType { get; set; } //CustomerDetailType>Name

    //Adress
    public int ApartmentNumber { get; set; } //CustomerAddress>ApartmentNumber
    public string City { get; set; } //CustomerAddress>City
    public string Country { get; set; } //CustomerAddress>Country
    public int HouseNumber { get; set; } //CustomerAddress>HouseNumber
    public string StreetName { get; set; } //CustomerAddress>Street
    public string PostCode { get; set; } //CustomerAddress>ZipCode
    public string AddressTypeName { get; set; } //CustomerAddressType>Name
}