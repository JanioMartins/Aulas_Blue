using BlueFashionRetailer.API;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    public abstract class ApiBaseController : ControllerBase
    {

        protected OkObjectResult ApiOk<T>(T results) =>
            Ok(CustomResponse(results));

        protected OkObjectResult ApiOk(string Message = "") => 
            Ok(CustomResponse(false, Message));

        protected OkObjectResult ApiOk(string Message = "") =>
            Ok(CustomResponse(false, Message));

        APIResponse<T> CustomResponse<T>(T results, bool Succeed = true, string Message = "") =>
            new APIResponse<T>()
            { 
                Results = results,
                Succeed = Succeed,
                Message = Message
            };

        APIResponse<string> CustomResponse(bool Succeed = true, string Message = "") =>
            new APIResponse<string>()
            {
                Succeed = Succeed,
                Message = Message
            };
    }
}
