using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity.Menu
{
    public class MenuEntity : BaseEntity
    {
        public MenuEntity()
        {
            this.SubMenus = new List<MenuEntity>();
        }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public IList<MenuEntity> SubMenus { get; set; }
    }
}
