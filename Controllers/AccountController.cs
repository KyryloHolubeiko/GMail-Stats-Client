using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace GMail_Stats_Client__Option_1_.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult IndexAccount()
        {
            return View();
        }
    }
}
