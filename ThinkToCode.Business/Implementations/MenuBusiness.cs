using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Business.Contracts;
using ThinkToCode.Common.Entity.Menu;
using ThinkToCode.Repository.Contract;

namespace ThinkToCode.Business.Implementations
{
    public class MenuBusiness : IMenuBusiness
    {
        IMenuRepository menuRepository;
        public MenuBusiness(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        public MenuDetailEntity GetMenu()
        {
            return this.menuRepository.GetMenu();
        }
    }
}
