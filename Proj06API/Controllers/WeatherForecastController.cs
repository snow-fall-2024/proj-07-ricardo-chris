using Microsoft.AspNetCore.Mvc;
using Proj06API.Data;
namespace Proj06API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {
        //private readonly ILogger<JokeController> _logger;
        //private readonly DbChristopheryoung26Context _context;
        //private static List<DbJoke> jokesAdded = new();
        //private static List<DbJokecategory> categoriesAdded = new();
        //private static List<DbAudience> audiencesAdded = new();


        //public JokeController(ILogger<JokeController> logger, DbChristopheryoung26Context context)
        //{
        //    _logger = logger;
        //    _context = context;
        //}

        //[HttpPost("AddJoke")]
        //public IResult AddJoke(DbJoke j)
        //{
        //    if (j == null || string.IsNullOrEmpty(j.Jokename) || string.IsNullOrEmpty(j.Joketext))
        //    {
        //        _logger.LogError("Invalid joke input: Jokename or Joketext is missing");
        //        return Results.BadRequest("Invalid joke input");
        //    }

        //    _context.Jokes.Add(j);
        //    _context.SaveChanges();
        //    jokesAdded.Add(j);

        //    _logger.LogInformation("Successfully added joke: {@joke}", j);
        //    return Results.Created("/joke", j);
        //}
        //[HttpGet("GetJoke/{id}")]
        //public ActionResult<DbJoke> GetJoke(int id)
        //{
        //    return _context.Jokes.Where(j => j.Id == id).FirstOrDefault();
        //}
        //[HttpGet("GetAllJokes/")]
        //public ActionResult<List<DbJoke>> GetAllJokes()
        //{
        //    return _context.Jokes.ToList();
        //}
        //[HttpPost("AddCategory")]
        //public IResult AddJokeCategory(DbJokecategory c)
        //{
        //    if (c == null) return Results.BadRequest("Bad request");

        //    _context.Jokecategories.Add(c);
        //    _context.SaveChanges();
        //    categoriesAdded.Add(c);
        //    return Results.Created("/jokecategory", c);
        //}
        //[HttpGet("GetCategory/{id}")]
        //public ActionResult<DbJokecategory> GetJokeCategory(int id)
        //{
        //    return _context.Jokecategories.Where(c => c.Id == id).First();
        //}
        //[HttpPost("AddAudience")]
        //public IResult AddAudience(DbAudience audience)
        //{
        //    if (audience == null) return Results.BadRequest("Bad request");

        //    _context.Audiences.Add(audience);
        //    _logger.LogInformation($"{audience.Id}");
        //    _context.SaveChanges();
        //    audiencesAdded.Add(audience);
        //    return Results.Created("/audience", audience);
        //}
        //[HttpGet("GetAudience/{id}")]
        //public ActionResult<DbAudience> GetAudience(int id)
        //{
        //    return _context.Audiences.Where(a => a.Id == id).First();
        //}
        //[HttpGet("admin/reset")]
        //public IResult ResetData()
        //{
        //    if (jokesAdded != null && jokesAdded.Any())
        //    {
        //        foreach (var joke in jokesAdded)
        //        {
        //            _context.Jokes.Remove(joke);
        //        }
        //        _context.SaveChanges();
        //    }
        //    if (categoriesAdded != null && categoriesAdded.Any())
        //    {
        //        foreach (var category in categoriesAdded)
        //        {
        //            _context.Jokecategories.Remove(category);
        //        }
        //        _context.SaveChanges();
        //    }
        //    if (audiencesAdded != null && audiencesAdded.Any())
        //    {
        //        foreach (var audience in audiencesAdded)
        //        {
        //            _context.Audiences.Remove(audience);
        //        }
        //        _context.SaveChanges();
        //    }

        //    return Results.Ok("Removed all changes");
        //}
    }

}
