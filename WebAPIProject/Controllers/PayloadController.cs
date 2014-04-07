using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;
using WebAPIProject.Services;

namespace WebAPIProject.Controllers
{
    public class PayloadController : ApiController
    {
        public PayloadService payloadService = new PayloadService();

        //This method captures the posted data and makes a service call that filters the payload and returns a response.
        //If the posted data is null or invalid or if any other error has ocurred a response of Bad Request is sent.
        [HttpPost]
        public HttpResponseMessage Post(DataModel model)
        {
            if (model != null)
            {
                ResponseModel responseModel = payloadService.FilterPayload(model.payload);

                if (responseModel.response!=null && responseModel.response.Count() > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, responseModel);
                }
            }
            
            return Request.CreateResponse(HttpStatusCode.BadRequest, new ErrorModel());
        }
    }
}
