using System;
using System.Collections.Generic;

namespace Proj06API.Data;

public partial class Deliveredjoke
{
    public int Id { get; set; }

    public DateOnly Delivereddate { get; set; }

    public int? Jokereactionid { get; set; }

    public int? Jokeid { get; set; }

    public int? Audienceid { get; set; }

    public string? Notes { get; set; }

    public virtual Categorizedaudience? Audience { get; set; }

    public virtual Categorizedjoke? Joke { get; set; }

    public virtual Jokereactioncategory? Jokereaction { get; set; }
}
