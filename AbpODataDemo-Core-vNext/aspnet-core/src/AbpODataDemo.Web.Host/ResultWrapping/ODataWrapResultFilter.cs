using Abp.Web.Results.Filters;
using System;

namespace AbpODataDemo.ResultWrapping
{
    public class ODataWrapResultFilter : IWrapResultFilter
    {
        public bool HasFilterForWrapOnError(string url, out bool wrapOnError)
        {
            wrapOnError = false;
            return new Uri(url).AbsolutePath.StartsWith("/odata", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool HasFilterForWrapOnSuccess(string url, out bool wrapOnSuccess)
        {
            wrapOnSuccess = false;
            return new Uri(url).AbsolutePath.StartsWith("/odata", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
