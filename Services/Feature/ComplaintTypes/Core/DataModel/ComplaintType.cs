using System;
using System.Collections.Generic;

namespace Services.Feature.ComplaintTypes.Core.DataModel;

public partial class ComplaintType
{
    public int ComplainttypeId { get; set; }

    public string? Type { get; set; }

    public int? Status { get; set; }
}
