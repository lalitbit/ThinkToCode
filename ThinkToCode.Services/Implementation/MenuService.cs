using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Business.Contracts;
using ThinkToCode.Common.Entity.Menu;
using ThinkToCode.Services.Contract;

namespace ThinkToCode.Services.Implementation
{
    public class MenuService : IMenuService
    {
        IMenuBusiness menuBusiness;
        public MenuService(IMenuBusiness menuBusiness)
        {
            this.menuBusiness = menuBusiness;
        }
        public MenuDetailEntity GetMenu()
        {
            return this.menuBusiness.GetMenu();
        }
    }
}
