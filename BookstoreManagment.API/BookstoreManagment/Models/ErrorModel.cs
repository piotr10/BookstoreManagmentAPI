﻿namespace BookstoreManagement.Api.Models;

public class ErrorModel
{
    public string ErrorMessage { get; set; }
    public string InnerException { get; set; }
}