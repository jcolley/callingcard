using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingcard.Controllers
{
    public class CallingCardController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "What What!";
        }

        [HttpGet]
        [Route("{FName}/{LName}/{Age}/{Color}")]
        public JsonResult Info(string fName, string lName, int age, string color)
        {
            var AnonObject = new {
                FirstName = fName,
                LastName = lName,
                Age = age,
                FavoriteColor = color
            };

            return Json(AnonObject);
        }
    }
}