using System.Web.Http;
using System.Web.Mvc;

namespace DynamicTest.Controllers
{
    public class DynamicController : ApiController
    {
        public JsonResult PostData([FromBody]dynamic model)
        {
            var jr = new JsonResult();               
            jr.Data = model;
            return jr;
        }
    }
}
