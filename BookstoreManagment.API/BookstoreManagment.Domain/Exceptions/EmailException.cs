namespace BookstoreManagement.Domain.Exceptions;

public class EmailException : Exception
{
    public EmailException(string email, Exception ex ) : base($"Email \"{email}\" is invalid.", ex)
    {
        throw new NotImplementedException();
    }
}