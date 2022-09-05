using MediatR;

namespace BookstoreManagement.Application.Customer.Commands.CreateCustomer;

public class CreateCustomerCommand : IRequest<int>
{
    //Customer
    public int CustomerId { get; set; }
    //CustomerDetail
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CustomerDetailTypeId { get; set; }
    public int CustomerAddressTypeId { get; set; }

    //CustomerDetail
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int HouseNumber { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }

    //CustomerContactDetail
    public string DetailContact { get; set; }
    public int CustomerContactDetailTypeId { get; set; }
}