using DOTNET_APPS.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace DOTNET_APPS.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : JsonApiController<Person>
    {
         public PeopleController(
            IJsonApiContext jsonApiContext,
            IEntityRepository<Person> entityRepository,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, entityRepository, loggerFactory)
        { }
    }
}