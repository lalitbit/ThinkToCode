using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity.Menu;

namespace ThinkToCode.Services.Contract
{
    public interface IMenuService
    {
        MenuDetailEntity GetMenu();
    }
}
