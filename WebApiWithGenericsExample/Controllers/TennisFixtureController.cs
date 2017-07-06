using Microsoft.AspNetCore.Mvc;
using WebApiWithGenericsExample.Domain;

namespace WebApiWithGenericsExample.Controllers
{
    [Route("api/[controller]")]
    public class TennisFixtureController : GenericFixtureControllerBase<TennisFixture, TennisAvailableSources>
    {

    }
}