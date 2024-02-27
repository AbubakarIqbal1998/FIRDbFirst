using System;
using System.Collections.Generic;

namespace Services.Feature.PoliceStations.Core.DataModel;

public partial class PoliceStation
{
    public int PolicestationId { get; set; }

    public string? Policestation1 { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? Status { get; set; }
}
