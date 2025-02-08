using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Appilcation.Models;

namespace YadLeyadBack.ApiFilters
{
    public class ApiResponseFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // This runs before the action executes
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                var apiResponse = new ApiResponse<object>(
                    objectResult.Value
                );
                apiResponse.Success = objectResult.StatusCode == 200;
                context.Result = new ObjectResult(apiResponse) { StatusCode = objectResult.StatusCode };
            }
        }
    }
}
