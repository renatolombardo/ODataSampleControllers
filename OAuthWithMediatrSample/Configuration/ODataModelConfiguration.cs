using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using OAuthWithMediatrSample.Data.Entities;

namespace OAuthWithMediatrSample.Configuration
{
    public class ODataModelConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string? routePrefix)
        {
            builder.EntitySet<Person>("Persons");
        }
    }
}
