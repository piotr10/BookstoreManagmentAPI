using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagement.Domain.Common;

public class AuditableEntity
{
    public int Id { get; set; }
    public string CreatedBy { get; set; } //= string.Empty;
    public DateTime Created { get; set; }
    public string ModifiedBy { get; set; } //= string.Empty;
    public DateTime? Modified { get; set; }
    public int StatusId { get; set; }
    public string InactivatedBy { get; set; }// = string.Empty;
    public DateTime? Inactivated { get; set; }
}