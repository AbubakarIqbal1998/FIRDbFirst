using System;
using System.Collections.Generic;

namespace Services.Feature.Firs.Core.DataModel;

public partial class Fir
{
    public int Firid { get; set; }

    public string? AccussedName { get; set; }

    public string? AvvussedFatherName { get; set; }

    public string? AccussedCnic { get; set; }

    public DateTime? Dateofincident { get; set; }

    public string? PlaceofIncident { get; set; }

    public string? Image { get; set; }

    public string? Ispolicevisited { get; set; }

    public DateTime? VisitedDate { get; set; }

    public string? Timeofincident { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? PolicestationId { get; set; }

    public string? Firdescription { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public int? ComplainttypeId { get; set; }

    public int? SectionId { get; set; }
}
