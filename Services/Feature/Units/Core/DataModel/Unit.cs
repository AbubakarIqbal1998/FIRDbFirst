using System;
using System.Collections.Generic;

namespace Services.Feature.Units.Core.DataModel;

public partial class Unit
{
    public int UnitId { get; set; }

    public string? Unit1 { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? Status { get; set; }
}
