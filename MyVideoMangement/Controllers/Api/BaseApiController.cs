using System.Web.Http;
using MyVideoMangement.Models;

namespace MyVideoMangement.Controllers.Api
{
    public class BaseApiController : ApiController
    {
        public ApplicationDbContext MyDbContext { get; }

        public BaseApiController()
        {
            MyDbContext = new ApplicationDbContext();
        }
    }
}