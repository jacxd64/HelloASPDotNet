using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers;

[Route("/hello")]
public class HelloController : Controller
{
    //GET /hello
    [HttpGet]
    public IActionResult Index()
    {
        //string html = "<form method='post' action='/helloworld/welcome'>" +
            //"<input type='text' name='name' />" +
            //"<input type='submit' value='Greet Me!' />" +
            //"</form>";
        //return Content(html, "text/html");
        return View();
    }

    //POST: /hello
    [HttpPost]
    public IActionResult welcome(string name)
    {
        ViewBag.person = name;
        return View();
    }
}
