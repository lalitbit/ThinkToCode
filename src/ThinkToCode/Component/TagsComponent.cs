using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThinkToCode.Common.Entity.Menu;
using ThinkToCode.Services.Contract;

namespace ThinkToCode.Component
{
    public class TagsComponent : ViewComponent
    {
        IMenuService menuService;
        public TagsComponent(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            MenuDetailEntity menu = this.menuService.GetMenu();
            return View("Default",menu);
        }
    }
}
