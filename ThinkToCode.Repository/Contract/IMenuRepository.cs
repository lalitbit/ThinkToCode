using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity.Menu;

namespace ThinkToCode.Repository.Contract
{
    public interface IMenuRepository
    {
        MenuDetailEntity GetMenu();
    }
}
