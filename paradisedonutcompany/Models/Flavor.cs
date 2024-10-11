using System;
using System.Collections.Generic;

namespace paradisedonutcompany.Models;

public partial class Flavor
{
    public int Id { get; set; }

    public string Flavorname { get; set; } = null!;

    public string? Image { get; set; }

    public string? Description { get; set; }

    public float? Price { get; set; }

    public string? Category { get; set; }
}
