namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class OrderDetailVm
{
    //Order
    public DateTime DayOfDelivery { get; set; } //Order>DeliveryDate
    public DateTime DayOfOrder { get; set; } //Order>OrderDate
    public decimal OrderPrice { get; set; } //Order>r
    public int OrderQuantity { get; set; } //Order>Quantity
    public string OrderTransportType { get; set; } //OrderTransportType>Name
    public string PaymentMethod { get; set; } //PaymentMethod>Name

    //Customer
    public string CustomerName { get; set; } //CustomerDetail>FirstName
    public string CustomerSurname { get; set; } //CustomerDetail>LastName
    //Customer Address
    public int ApartmentNumber { get; set; } //CustomerAddress>ApartmentNumber
    public string City { get; set; } //CustomerAddress>City
    public string Country { get; set; } //CustomerAddress>Country
    public int HouseNumber { get; set; } //CustomerAddress>HouseNumber
    public string StreetName { get; set; } //CustomerAddress>Street
    public string PostCode { get; set; } //CustomerAddress>ZipCode

    //Book
    public string BookName { get; set; } //BookDetail>Name
    public decimal BookPrice { get; set; } //BookDetail>Price
}