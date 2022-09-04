using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Persistance;

public static class Seed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(d =>
            {
                d.HasData(new Author()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty
                });
                d.OwnsOne(d => d.AuthorName)
                    .HasData(new {AuthorId = 1, FirstName = "Henryk", LastName = "Sienkiewicz"});

                d.HasData(new Author()
                {
                    Id = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty
                });
                d.OwnsOne(d => d.AuthorName).HasData(new {AuthorId = 2, FirstName = "Stanisław", LastName = "Lem"});
            }
        );

        modelBuilder.Entity<AuthorBiography>().HasData(
            new AuthorBiography()
            {
                Id = 1,
                AuthorId = 1,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty,
                Country = "Poland",
                DateOfBirth = new DateTime(1846, 5, 5),
                PlaceOfBirth = "Wola Okrzejska"
            },

            new AuthorBiography()
            {
                Id = 2,
                AuthorId = 2,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty,
                Country = "Poland",
                DateOfBirth = new DateTime(1921, 9, 12),
                PlaceOfBirth = "Kraków"
            }
        );

        modelBuilder.Entity<AuthorContactDetailType>().HasData(
            new AuthorContactDetailType() {Id = 1, Name = "None"},
            new AuthorContactDetailType() {Id = 2, Name = "Phone"},
            new AuthorContactDetailType() {Id = 3, Name = "Email"}
        );

        modelBuilder.Entity<AuthorContactDetail>().HasData(
            new AuthorContactDetail()
            {
                Id = 1,
                AuthorId = 1,
                AuthorContactDetailTypeId = 2,
                Name = "No contacts",
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            },

            new AuthorContactDetail()
            {
                Id = 2,
                AuthorId = 2,
                AuthorContactDetailTypeId = 3,
                Name = "stanislawlem@wp.pl",
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            }
        );

        modelBuilder.Entity<Book>().HasData(
            new Book()
            {
                Id = 1,
                AuthorId = 1,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            },

            new Book()
            {
                Id = 2,
                AuthorId = 2,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            }
        );

        modelBuilder.Entity<Genre>().HasData(
            new Genre() {Id = 1, Name = "Biography"},
            new Genre() {Id = 2, Name = "Drama"},
            new Genre() {Id = 3, Name = "Historical Novel"}
        );

        modelBuilder.Entity<BookDetail>().HasData(
            new BookDetail()
            {
                Id = 1, BookId = 1, Name = "Ogniem i Mieczem", PublishedBookDate = new DateTime(1884, 1, 1), Price = 10,
                GenreId = 1
            },
            new BookDetail()
            {
                Id = 2, BookId = 1, Name = "Potop", PublishedBookDate = new DateTime(1886, 1, 1), Price = 15,
                GenreId = 2
            },
            new BookDetail()
            {
                Id = 3, BookId = 1, Name = "Pan Wołodyjowski", PublishedBookDate = new DateTime(1888, 1, 1), Price = 11,
                GenreId = 3
            },
            new BookDetail()
            {
                Id = 4, BookId = 1, Name = "Quo Vadis", PublishedBookDate = new DateTime(1896, 1, 1), Price = 12,
                GenreId = 1
            },
            new BookDetail()
            {
                Id = 5, BookId = 1, Name = "Krzyżacy", PublishedBookDate = new DateTime(1900, 1, 1), Price = 14,
                GenreId = 1
            },

            new BookDetail()
            {
                Id = 6, BookId = 2, Name = "Wejście na orbitę", PublishedBookDate = new DateTime(1962, 1, 1),
                Price = 14, GenreId = 1
            },
            new BookDetail()
            {
                Id = 7, BookId = 2, Name = "Summa technologiae", PublishedBookDate = new DateTime(1964, 1, 1),
                Price = 14, GenreId = 2
            },
            new BookDetail()
            {
                Id = 8, BookId = 2, Name = "Filozofia przypadku", PublishedBookDate = new DateTime(1968, 1, 1),
                Price = 14, GenreId = 3
            }
        );

        modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                Id = 1, StatusId = 1, Created = DateTime.Now, CreatedBy = string.Empty, InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            },
            new Customer()
            {
                Id = 2, StatusId = 1, Created = DateTime.Now, CreatedBy = string.Empty, InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            }
        );

        modelBuilder.Entity<CustomerDetailType>().HasData(
            new CustomerDetailType() {Id = 1, Name = "Private person"},
            new CustomerDetailType() {Id = 2, Name = "Entrepreneur"} //przedsiębiorca
        );

        modelBuilder.Entity<CustomerDetail>(d =>
        {
            d.HasData(new CustomerDetail()
            {
                Id = 1,
                CustomerId = 1,
                CustomerDetailTypeId = 1,
                CustomerAddressTypeId = 1,
                FirstName = "Piotr",
                LastName = "Cz",
                DetailContact = "piotrCz@example.com",
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            });
            d.OwnsOne(d => d.Adres).HasData(new
            {
                CustomerDetailId = 1,
                ApartmentNumber = 12,
                City = "Warsaw",
                Country = "Poland",
                HouseNumber = 12,
                Street = "Warszawska",
                ZipCode = "01-001"
            });

            d.HasData(new CustomerDetail()
            {
                Id = 2,
                CustomerId = 2,
                CustomerDetailTypeId = 2,
                CustomerAddressTypeId = 2,
                FirstName = "Ola",
                LastName = "Sa",
                DetailContact = "olaSa@example.com",
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = string.Empty,
                InactivatedBy = string.Empty,
                ModifiedBy = string.Empty
            });
            d.OwnsOne(d => d.Adres).HasData(new
            {
                CustomerDetailId = 2,
                ApartmentNumber = 10,
                City = "Cracow",
                Country = "Poland",
                HouseNumber = 10,
                Street = "Krakowska",
                ZipCode = "01-001"
            });




            modelBuilder.Entity<CustomerAddressType>().HasData(
                new CustomerAddressType() {Id = 1, Name = "Address of residence"}, // Adres zamieszkania
                new CustomerAddressType() {Id = 2, Name = "Residences"} //Adres pobytu
            );

            modelBuilder.Entity<CustomerAddress>().HasData(
                new CustomerAddress()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty,

                },
                new CustomerAddress()
                {
                    Id = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty,

                }
            );

            modelBuilder.Entity<OrderTransportType>().HasData(
                new OrderTransportType() {Id = 1, Name = "Paczkomat"},
                new OrderTransportType() {Id = 2, Name = "Kurier"}
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod() {Id = 1, Name = "Mobile payments"},
                new PaymentMethod() {Id = 2, Name = "Electronic bank transfers"}
            );

            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    CustomerId = 1,
                    BookId = 1,
                    OrderTransportTypeId = 1,
                    PaymentMethodId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty,
                    DeliveryDate = new DateTime(2022, 1, 15),
                    OrderDate = new DateTime(2022, 1, 1),
                    OrderPrice = 22,
                    Quantity = 1,
                    Name = "Ogniem i Mieczem",
                    BookPrice = 10
                },
                new Order()
                {
                    Id = 2,
                    CustomerId = 2,
                    BookId = 2,
                    OrderTransportTypeId = 2,
                    PaymentMethodId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = string.Empty,
                    InactivatedBy = string.Empty,
                    ModifiedBy = string.Empty,
                    DeliveryDate = new DateTime(2022, 1, 15),
                    OrderDate = new DateTime(2022, 1, 1),
                    OrderPrice = 33,
                    Quantity = 2,
                    Name = "Potop",
                    BookPrice = 15
                }
            );
        });
    }
}