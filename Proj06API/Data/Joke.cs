using System;
using System.Collections.Generic;

namespace Proj06API.Data;

public partial class Joke
{
    public int Id { get; set; }

    public string? Jokename { get; set; }

    public string? Joketext { get; set; }

    public virtual ICollection<Categorizedjoke> Categorizedjokes { get; set; } = new List<Categorizedjoke>();
}
