using System;
using System.Collections.Generic;

namespace DBFirst_of_Entity_Framework.Entities;

public partial class CustomerDemographic
{
    public string Id { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Ids { get; set; } = new List<Customer>();
}
