using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicketsReservation.Domain.Common;

public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; protected set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime? UpdatedDate { get; private set; }

    protected BaseEntity()
    {
        CreatedDate = DateTime.UtcNow;
    }

    public void SetUpdatedDate()
    {
        UpdatedDate = DateTime.UtcNow;
    }
}