﻿using Microsoft.AspNetCore.Mvc;
namespace WebMvcRouting.Controllers
{
    #region snippet_1
    public class UrlGenerationController : Controller
    {
        public IActionResult Source()
        {
            // Generates /UrlGeneration/Destination
            var url = Url.Action("Destination");
            return ControllerContext.MyDisplayRouteInfo("", $" URL = {url}");
        }

        public IActionResult Destination() =>
            ControllerContext.MyDisplayRouteInfo();
    }
    #endregion
}