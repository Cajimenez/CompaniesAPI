using CompaniesAPI.Models;
using CompaniesAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CompaniesAPI.Controllers
{
    [Authorize(Users = "UserApi2")]
    [RoutePrefixAttribute("Api2")]
    public class Api2Controller : ApiController
    {
        Api2Service _service;
        public Api2Controller()
        {
            _service = new Api2Service();
        }

        [HttpPost()]
        [Route("BestDeal")]
        //[ValidateAntiForgeryToken]
        public HttpResponseMessage BestDeal([FromBody] Api2Request request)
        {
            try
            {
                if (request == null || request.Cartons == null || request.Cartons.Count() == 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                var response = new Api2Response() { amount = _service.GetBestDeal(request.Cartons) };
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
