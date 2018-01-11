using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.Mvc.Extensions;
using Abp.Dependency;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Reflection;

public class ResultFilter : IResultFilter, ITransientDependency
{
    private readonly IAbpAspNetCoreConfiguration _configuration;

    public ResultFilter(IAbpAspNetCoreConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        if (context.HttpContext.Request.Path.Value.StartsWith("/odata"))
        {
            var methodInfo = context.ActionDescriptor.GetMethodInfo();

            var wrapResultAttribute =
                GetSingleAttributeOfMemberOrDeclaringTypeOrDefault(
                    methodInfo,
                    _configuration.DefaultWrapResultAttribute
                );

            wrapResultAttribute.WrapOnSuccess = false;
        }
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        // No action
    }

    private TAttribute GetSingleAttributeOfMemberOrDeclaringTypeOrDefault<TAttribute>(MemberInfo memberInfo, TAttribute defaultValue = default(TAttribute), bool inherit = true)
        where TAttribute : class
    {
        return memberInfo.GetCustomAttributes(true).OfType<TAttribute>().FirstOrDefault()
               ?? memberInfo.DeclaringType?.GetTypeInfo().GetCustomAttributes(true).OfType<TAttribute>().FirstOrDefault()
               ?? defaultValue;
    }
}
