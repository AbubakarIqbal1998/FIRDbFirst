using System;
using System.Collections.Generic;

namespace Services.Feature.Designations.Core.DataModel;

public partial class Designation
{
    public int DesignationId { get; set; }

    public string? Designation1 { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? Status { get; set; }
}
