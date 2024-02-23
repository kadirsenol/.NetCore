using System;
using System.Collections.Generic;

namespace LINQ_Sorgulari.Entities;

public partial class Abc
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? Adet { get; set; }
}
