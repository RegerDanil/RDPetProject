using Microsoft.AspNetCore.Mvc;

namespace SportStoreRD.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
