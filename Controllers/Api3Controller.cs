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
    [Authorize(Users = "UserApi3")]
    [RoutePrefixAttribute("Api3")]
    public class Api3Controller : ApiController
    {
        Api3Service _service;
        public Api3Controller()
        {
            _service = new Api3Service();
        }

        [HttpPost()]
        [Route("BestDeal")]
        public HttpResponseMessage BestDeal([FromBody]Api3Request request)
        {
            try
            {
                if (request == null || request.packages == null || request.packages.Count() == 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                var response = new Api3Response() { quote = _service.GetBestDeal(request.packages.Select(x=>x.package)) };
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception error)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,error.Message);
            }
        }
    }
}
