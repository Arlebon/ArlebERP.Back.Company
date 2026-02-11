using ArlebERP.Company.BLL.Exceptions;
using System.Text.Json;

namespace ArlebERP.Company.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        public async Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            switch (ex)
            {
                case ArlebERPCompanyException e:
                    await SendResponse(context, e);
                    break;

                case Exception:
                    context.Response.StatusCode = 500;

                    var response = new
                    {
                        message = ex.Message,
                    };

                    string jsonResponse = JsonSerializer.Serialize(response);
                    await context.Response.WriteAsync(jsonResponse);
                    break;
            }
        }

        public async Task SendResponse(HttpContext context, ArlebERPCompanyException ex)
        {
            context.Response.StatusCode = ex.StatusCode;

            var response = new
            {
                content = ex.Content,
            };

            string jsonResponse = JsonSerializer.Serialize(response);
            await context.Response.WriteAsync(jsonResponse);
        }
    }
}
