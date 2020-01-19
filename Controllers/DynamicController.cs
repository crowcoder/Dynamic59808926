using System.Diagnostics;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace DynamicTest.Controllers
{
    public class DynamicController : ApiController
    {
        [HttpPost]
        public JsonResult PostData([FromBody]dynamic model)
        {
            var jr = new JsonResult();               
            jr.Data = model;
            return jr;
        }
    }
}
