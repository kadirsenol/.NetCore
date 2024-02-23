using System;
using System.Collections.Generic;

namespace LINQ_Sorgulari.Entities;

public partial class Territory
{
    public string Id { get; set; } = null!;

    public string TerritoryDescription { get; set; } = null!;

    public int RegionId { get; set; }

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<Employee> Ids { get; set; } = new List<Employee>();
}
