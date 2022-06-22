using CompaniesAPI.Models;
using CompaniesAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace TestCompaniesApi.Controllers
{
    [Authorize(Users = "UserApi1")]
    [RoutePrefixAttribute("Api1")]
    public class Api1Controller : ApiController
    {
        Api1Service _service;

        public Api1Controller()
        {
            _service = new Api1Service();
        }

        [HttpPost()]
        [Route("BestDeal")]
        public HttpResponseMessage BestDeal([FromBody] Api1Request request)
        {
            try
            {
                if (request == null || request.PackageDimensions == null || request.PackageDimensions.Count() == 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                var response = new Api1Response() { total = _service.GetBestDeal(request.PackageDimensions) };
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
