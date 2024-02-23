using System;
using System.Collections.Generic;

namespace LINQ_Sorgulari.Entities;

public partial class SiparislerinUrunIsimleri
{
    public int SiparisNo { get; set; }

    public string Urun { get; set; } = null!;

    public string Kategori { get; set; } = null!;

    public short Adet { get; set; }

    public decimal Fiyat { get; set; }
}
