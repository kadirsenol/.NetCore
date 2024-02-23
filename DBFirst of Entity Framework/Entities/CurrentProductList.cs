using System;
using System.Collections.Generic;

namespace DBFirst_of_Entity_Framework.Entities;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
