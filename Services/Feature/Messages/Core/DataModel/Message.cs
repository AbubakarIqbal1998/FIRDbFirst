using System;
using System.Collections.Generic;

namespace Services.Feature.Messages.Core.DataModel;

public partial class Message
{
    public int MessageId { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? PolicestationId { get; set; }

    public string? Message1 { get; set; }

    public string? PostedDate { get; set; }

    public string? Reply { get; set; }

    public int? Seen { get; set; }
}
