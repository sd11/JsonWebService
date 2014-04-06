using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIProject.Models;

namespace WebAPIProject.Services
{
    public class PayloadService
    {
        public ResponseModel FilterPayload(Payload[] payload)
        {
            ResponseModel responseModel = new ResponseModel();

            if (payload != null && payload.Count() > 0)
            {
                payload = payload.Where(x => x.drm && x.episodeCount > 0).ToArray<Payload>();

                int responseLength = payload.Count();
                responseModel.response = new Response[responseLength];
                int index = 0;

                foreach (var payld in payload)
                {
                    Response response = new Response()
                    {
                        image = payld.image.showImage,
                        slug = payld.slug,
                        title = payld.title
                    };
                    responseModel.response[index] = response;
                    index++;
                }
            }
            
            return responseModel;
        }
    }
}