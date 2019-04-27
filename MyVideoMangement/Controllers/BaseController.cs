using System.Web.Mvc;
using MyVideoMangement.Models;

namespace MyVideoMangement.Controllers
{
    public class BaseController : Controller
    {
        public ApplicationDbContext MyDbContext { get; }

        public BaseController()
        {
            MyDbContext = new ApplicationDbContext();
        }
    }
}