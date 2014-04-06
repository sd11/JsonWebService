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

        [HttpPut]
        public HttpResponseMessage Put(DataModel model)
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
