using System;
using System.Collections.Generic;

namespace Services.Feature.Districts.Core.DataModel;

public partial class District
{
    public int DistrictId { get; set; }

    public string? District1 { get; set; }

    public int? ProvinceId { get; set; }

    public int? Status { get; set; }
}
