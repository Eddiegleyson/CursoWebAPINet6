using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiCatologo.Filters
{
    public class ApiLoggingFilter : IActionFilter
    {
        private readonly ILogger<ApiLoggingFilter> _logger;
        public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
        {
            _logger = logger;
        }
       
        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Executando - OnActionExecuting");
            _logger.LogInformation("###############################");
            _logger.LogInformation($"{DateTime.Now.ToLongDateString()}");
            _logger.LogInformation($"ModelState : {context.ModelState.IsValid}");
            _logger.LogInformation("###############################");
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Executando - OnActionExecuted");
            _logger.LogInformation("###############################");
            _logger.LogInformation($"{DateTime.Now.ToLongDateString()}");
            _logger.LogInformation($"ModelState : {context.ModelState.IsValid}");
            _logger.LogInformation("###############################");
        }

    }
}