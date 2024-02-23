using System;
using System.Collections.Generic;

namespace LINQ_Sorgulari.Entities;

public partial class Region
{
    public int Id { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
