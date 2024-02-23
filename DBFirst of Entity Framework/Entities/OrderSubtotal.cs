using System;
using System.Collections.Generic;

namespace DBFirst_of_Entity_Framework.Entities;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
