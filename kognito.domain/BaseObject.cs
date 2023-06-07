using System.ComponentModel.DataAnnotations.Schema;

namespace kognito.domain;

public abstract class BaseObject
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
