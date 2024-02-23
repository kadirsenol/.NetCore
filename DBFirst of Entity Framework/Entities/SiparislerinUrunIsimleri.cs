using System;
using System.Collections.Generic;

namespace DBFirst_of_Entity_Framework.Entities;

public partial class SiparislerinUrunIsimleri
{
    public int SiparisNo { get; set; }

    public string Urun { get; set; } = null!;

    public string Kategori { get; set; } = null!;

    public short Adet { get; set; }

    public decimal Fiyat { get; set; }
}
