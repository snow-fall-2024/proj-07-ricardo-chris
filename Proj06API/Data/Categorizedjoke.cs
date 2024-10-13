using System;
using System.Collections.Generic;

namespace Proj06API.Data;

public partial class Categorizedjoke
{
    public int Id { get; set; }

    public int? Jokeid { get; set; }

    public int? Jokecategoryid { get; set; }

    public virtual ICollection<Deliveredjoke> Deliveredjokes { get; set; } = new List<Deliveredjoke>();

    public virtual Joke? Joke { get; set; }

    public virtual Jokecategory? Jokecategory { get; set; }
}
