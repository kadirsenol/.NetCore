using System;
using System.Collections.Generic;

namespace DBFirst_of_Entity_Framework.Entities;

public partial class Region
{
    public int Id { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
