using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lvmendes.UploadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        //[HttpPost]
        //[Route(nameof(UploadFile))]
        //public FileUploadResult UploadFile()
        //{
        //    return _FileUploader.UploadFile(Request.Form.Files[0]);
        //}
        private static void ProcessActionParameters(OperationFilterContext context, ref List<string> formFileParameterNames,
       ref List<string> formFileSubParameterNames)
        {
            foreach (var actionParameter in context.ApiDescription.ActionDescriptor.Parameters)
            {
                var properties =
                    actionParameter.ParameterType.GetProperties()
                        .Where(p => p.PropertyType == typeof(IFormFile))
                        .Select(p => p.Name)
                        .ToArray();

                if (properties.Length != 0)
                {
                    formFileParameterNames.AddRange(properties);
                    formFileSubParameterNames.AddRange(properties);
                    continue;
                }

                if (actionParameter.ParameterType != typeof(IFormFile)) continue;
                formFileParameterNames.Add(actionParameter.Name);
            }
        }

        //private static void ProcessParameters(ref IList<IParameter> parameters, List<string> formFileSubParameterNames)
        //{
        //    foreach (var parameter in parameters.ToArray())
        //    {
        //        if (!(parameter is NonBodyParameter) || parameter.In != "formData") continue;

        //        if (formFileSubParameterNames.Any(p => parameter.Name.StartsWith(p + "."))
        //            || formFilePropertyNames.Contains(parameter.Name))
        //            parameters.Remove(parameter);
        //    }
        //}
    }
}
