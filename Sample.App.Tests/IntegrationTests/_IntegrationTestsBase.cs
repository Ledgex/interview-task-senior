using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Sample.App.Tests.IntegrationTests
{
    public class IntegrationTestsBase
    {
        public TContentType AssertResponseIs<TResultType, TContentType>(IActionResult result)
            where TResultType : ObjectResult
        {
            Assert.IsInstanceOf<TResultType>(result);
            var typedResult = (TResultType)result;
            Assert.IsInstanceOf<TContentType>(typedResult.Value);
            var typedContent = (TContentType)typedResult.Value;
            return typedContent;
        }
    }
}