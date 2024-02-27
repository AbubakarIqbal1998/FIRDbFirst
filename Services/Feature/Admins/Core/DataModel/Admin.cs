using System;
using System.Collections.Generic;

namespace Services.Feature.Admins.Core.DataModel;

public partial class Admin
{
    public int AdminId { get; set; }

    public int? DistrictId { get; set; }

    public int? ProvinceId { get; set; }

    public int? PoliceStationId { get; set; }

    public int? UnitId { get; set; }

    public int? DesignationId { get; set; }

    public string? Name { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? Cnic { get; set; }

    public string? Contact { get; set; }

    public int? Status { get; set; }

    public string? Image { get; set; }
}
