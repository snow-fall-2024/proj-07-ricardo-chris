using System;
using System.Collections.Generic;

namespace Proj06API.Data;

public partial class Categorizedaudience
{
    public int Id { get; set; }

    public int? Audienceid { get; set; }

    public int? Audiencecategoryid { get; set; }

    public virtual Audience? Audience { get; set; }

    public virtual Audiencecategory? Audiencecategory { get; set; }

    public virtual ICollection<Deliveredjoke> Deliveredjokes { get; set; } = new List<Deliveredjoke>();
}
