﻿using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.Entities.Order;
using BookstoreManagement.Domain.ValueObjects;
using BookstoreManagement.Persistance;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BookstoreManagement.UnitTests.Common;

public class BookstoreDbContextFactory
{
    public static Mock<BookstoreDbContext> Create()
    {
        var dateTime = new DateTime(2000, 1, 1);
        var dateTimeMock = new Mock<IDateTime>();
        dateTimeMock.Setup(m => m.Now).Returns(dateTime);

        var currentUserMock = new Mock<ICurrentUserService>();
        currentUserMock.Setup(m => m.Email).Returns("user@user.pl");
        currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);

        var options = new DbContextOptionsBuilder<BookstoreDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

        var mock = new Mock<BookstoreDbContext>(options, dateTimeMock.Object, currentUserMock.Object) {CallBase = true};

        var context = mock.Object;
        context.Database.EnsureCreated();

        //Autora
        // Author
        var author = new Domain.Entities.Author.Author()
        {
            Id = 3,
            StatusId = 1,
            AuthorName = new PersonName()
            {
                FirstName = "Person",
                LastName = "Test"
            }
        };
        context.Authors.Add(author);

        // AuthorBiography
        var authorBiography = new AuthorBiography()
        {
            Id = 3,
            AuthorId = 3,
            StatusId = 1,
            Country = "Poland",
            DateOfBirth = new DateTime(1993, 1, 1),
            PlaceOfBirth = "Cracow"
        };
        context.AuthorBiographies.Add(authorBiography);

        // AuthorContactDetailType
        var authorContactDetailType = new AuthorContactDetailType()
        {
            Id = 4,
            Name = "Fax"
        };
        context.AuthorContactDetailTypes.Add(authorContactDetailType);

        // AuthorContactDetail
        var contactDetail = new AuthorContactDetail()
        {
            Id = 3,
            AuthorId = 3,
            AuthorContactDetailTypeId = 4,
            Name = "ptest@example.pl",
            StatusId = 1
        };
        context.AuthorContactDetails.Add(contactDetail);
        
        //Book 
        // Genre
        var genre = new Genre()
        {
            Id = 4,
            Name = "Horror"
        };
        context.Genres.Add(genre);

        // Book
        var book = new Domain.Entities.Book.Book()
        {
            Id = 9,
            AuthorId = 3,
            StatusId = 1,
            Name = "400 Bad Request",
            PublishedBookDate = new DateTime(1900, 1, 1),
            Price = 222,
            GenreId = 4
        };
        context.Books.Add(book);

        //Customer
        // Customer
        var customer = new Domain.Entities.Customer.Customer()
        {
            Id = 3,
            StatusId = 1,
        };
        context.Customers.Add(customer);

        // CustomerDetailType
        var customerDetailType = new CustomerDetailType()
        {
            Id = 3,
            Name = "Company"
        };
        context.CustomerDetailTypes.Add(customerDetailType);

        // CustomerAddressType
        var customerAddressType = new CustomerAddressType()
        {
            Id = 3,
            Name = "Private address"
        };
        context.CustomerAddressTypes.Add(customerAddressType);

        // CustomerDetail
        var customerDetail = new CustomerDetail()
        {
            Id = 3,
            CustomerId = 3,
            CustomerDetailTypeId = 3,
            CustomerAddressTypeId = 3,
            FirstName = "Piotr",
            LastName = "Customer",
            StatusId = 1,

            Adres = new Adres()
            {
                ApartmentNumber = 222,
                City = "Piaseczno",
                Country = "Poland",
                HouseNumber = 222,
                Street = "Piaseczyńska",
                ZipCode = "05-500"
            }
        };
        context.CustomerDetails.Add(customerDetail);

        // CustomerContactDetailType
        var customerContactDetailType = new CustomerContactDetailType()
        {
            Id = 4,
            Name = "Fax"
        };
        context.CustomerContactDetailTypes.Add(customerContactDetailType);

        //CustomerContactDetail
        var customerContactDetail = new CustomerContactDetail()
        {
            Id = 3,
            ContactName = "pczerskiCustomer@example.com",
            CustomerContactDetailTypeId = 4,
            CustomerId = 3,
            StatusId = 1,
        };
        context.CustomerContactDetails.Add(customerContactDetail);

        //Order
        // OrderTransportType
        var orderTransportType = new OrderTransportType()
        {
            Id = 3,
            Name = "Horse"
        };
        context.OrderTransportTypes.Add(orderTransportType);

        // PaymentMethod
        var paymentMethod = new PaymentMethod()
        {
            Id = 3,
            Name = "Pay on delivery"
        };
        context.PaymentMethods.Add(paymentMethod);

        //Order
        var order = new Domain.Entities.Order.Order()
        {
            Id = 3,
            CustomerId = 3,
            BookId = 9,
            OrderTransportTypeId = 3,
            PaymentMethodId = 3,
            StatusId = 1,
            DeliveryDate = new DateTime(2022, 1, 15),
            OrderDate = new DateTime(2022, 1, 1),
            OrderPrice = 111,
            Quantity = 3,
            Name = "Potop",
            BookPrice = 15
        };
        context.Orders.Add(order);

        context.SaveChanges();

        return mock;
    }

    public static void Destroy(BookstoreDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Dispose();
    }
}