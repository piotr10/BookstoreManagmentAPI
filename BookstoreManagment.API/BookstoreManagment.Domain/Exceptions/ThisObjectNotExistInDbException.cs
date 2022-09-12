namespace BookstoreManagement.Domain.Exceptions;

public class ThisObjectNotExistInDbException : Exception
{
    public ThisObjectNotExistInDbException(string objectName = "Object")
        : base($"{objectName} not found in database", new Exception())
    {
    }
}