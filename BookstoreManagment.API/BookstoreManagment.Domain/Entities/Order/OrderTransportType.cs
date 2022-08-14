﻿using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Order;

public class OrderTransportType : AuditableEntity
{
    public string Name { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}