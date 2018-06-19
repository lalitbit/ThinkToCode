using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity.Menu;
using ThinkToCode.Repository.Contract;
using ThinkToCode.Repository.DbData;

namespace ThinkToCode.Repository.FileImplementation
{
    public class MenuFileRepository : Common.BaseRepository<MenuDetailEntity>, IMenuRepository
    {
        MenuDataTable menuDataTable;

        public MenuFileRepository()
        {
            this.menuDataTable = MenuDataTable.Instance;
        }



        public MenuDetailEntity GetMenu()
        {
            return this.menuDataTable.PopulateMenu();
        }
    }
}
