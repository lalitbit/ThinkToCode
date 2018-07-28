using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThinkToCode.Component
{
    public class About : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("index");
        }
    }
}
