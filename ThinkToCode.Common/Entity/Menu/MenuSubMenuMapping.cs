using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity.Menu
{
    public class MenuSubMenuMapping
    {
        public int MenuId { get; set; }
        public int SubMenuId { get; set; }
        public int DisplayOrder { get; set; }
    }
}
