namespace BookstoreManagement.Domain.Entities.Customer;

public class Customer
{
    public int Id { get; set; }
    public ICollection<Book.Book> Books { get; set; }
    public CustomerDetail CustomerDetail { get; set; }
    public ICollection<Order.Order> Orders { get; set; }
}