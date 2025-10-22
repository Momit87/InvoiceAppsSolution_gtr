using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceApps.Api.Services
{
    public class FileUploadOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var fileUploadMime = "multipart/form-data";

            if (operation.RequestBody == null || !operation.RequestBody.Content.ContainsKey(fileUploadMime))
            {
                return;
            }

            var fileUploadObject = operation.RequestBody.Content[fileUploadMime];
            var parametersToRemove = new List<string>();

            foreach (var parameter in operation.Parameters)
            {
                if (parameter.In == ParameterLocation.Query)
                {
                    parametersToRemove.Add(parameter.Name);
                }
            }

            foreach (var parameterName in parametersToRemove)
            {
                operation.Parameters.Remove(operation.Parameters.First(p => p.Name == parameterName));
            }

            fileUploadObject.Schema.Properties.Clear();
            fileUploadObject.Schema.Properties.Add("file", new OpenApiSchema
            {
                Type = "string",
                Format = "binary"
            });
        }
    }
}
