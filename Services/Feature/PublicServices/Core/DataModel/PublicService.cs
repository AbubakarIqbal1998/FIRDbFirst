using System;
using System.Collections.Generic;

namespace Services.Feature.PublicServices.Core.DataModel;

public partial class PublicService
{
    public int PublicServiceId { get; set; }

    public string? Service { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public int? DistrictId { get; set; }

    public int? PolicestationId { get; set; }

    public int? Status { get; set; }
}
