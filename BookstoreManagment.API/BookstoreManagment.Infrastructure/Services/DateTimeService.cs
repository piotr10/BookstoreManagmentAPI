using BookstoreManagement.Application.Interfaces;

namespace BookstoreManagement.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}