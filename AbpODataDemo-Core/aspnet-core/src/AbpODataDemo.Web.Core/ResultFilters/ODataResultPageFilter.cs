using System;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.Mvc.Results;
using Abp.AspNetCore.Mvc.Results.Wrapping;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AbpODataDemo.ResultFilters
{
    public class ODataResultPageFilter : AbpResultFilter
    {
        public ODataResultPageFilter(IAbpAspNetCoreConfiguration configuration, IAbpActionResultWrapperFactory actionResultWrapperFactory)
            : base(configuration, actionResultWrapperFactory)
        {

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.HttpContext.Request.Path.Value.StartsWith("/odata", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }

            base.OnResultExecuting(context);
        }
    }
}
